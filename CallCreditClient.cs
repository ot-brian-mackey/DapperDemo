using System;
using System.Linq;

namespace OneTechnologies.Credit.CallCredit.Domain
{
    public class CallCreditClient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientStatusName { get; set; }
        public Guid GlobalClientId { get; set; }
        public Guid? UserIdentifier { get; set; }
        public string UserReferenceNumber { get; set; }
        public DateTime? LastScoreRequestDate { get; set; }
        public DateTime? LastReportRequestDate { get; set; }

        public bool ShouldRecheckCallCreditStatus()
        {
            return true;
            /*
            return ClientStatusName.IsNullOrEmpty()
                || ClientStatusName == CallCreditClientStatus.PENDING_KBA
                || ClientStatusName == CallCreditClientStatus.POST_IN_PROOF
                || ClientStatusName == CallCreditClientStatus.POST_IN_PROOF_Approved;*/
        }

        public bool RequiresSave()
        {
            return GlobalClientId.Equals(Guid.Empty);
        }

        /// <summary>
        /// If the client has not requested a report within the same day as this request,
        /// permit the retrieval of a new report
        /// </summary>
        /// <returns></returns>
        public bool CanRequestNewScore()
        {
            // If they got a score today, don't let them refresh report
            return LastScoreRequestDate.HasValue == false //Score never requested, so go ahead
                || LastScoreRequestDate.Value.ToUniversalTime().ToShortDateString() != DateTime.UtcNow.ToShortDateString();
        }

        public bool CanRequestNewReport()
        {
            // If they got a report today, don't let them refresh report
            return LastReportRequestDate.HasValue == false //Report never requested, so go ahead
                || LastReportRequestDate.Value.ToUniversalTime().ToShortDateString() != DateTime.UtcNow.ToShortDateString();
        }

        public bool IsValid()
        {
            return ClientStatusName != string.Empty
                && (GlobalClientId != Guid.Empty
                || UserIdentifier != Guid.Empty);
        }
    }
    public static class CallCreditClientStatus
    {
        public static string PASSED_KBA;
        public static string PENDING_KBA;
        public static string POST_IN_PROOF;
        public static string POST_IN_PROOF_Approved;
        public static string POST_IN_PROOF_Cancelled;
        public static string POST_IN_PROOF_Rejected;
    }
}
