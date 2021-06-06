namespace Portfolio.Standard.Models
{
    public class ResponseMessage
	{
		#region Constructors & Destructors

		public ResponseMessage()
		{
			Status = ResponseStatus.Failed;
			Message = string.Empty;
		}

		#endregion

		#region Properties

		#region Public Properties

		public string Message { get; set; }
		public ResponseStatus Status { get; set; }

		#endregion

		#endregion
	}
}