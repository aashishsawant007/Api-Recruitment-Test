using System;

namespace Nagarro.Standard.Models
{
   public class HandledException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HandledException"/> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public HandledException(string message) : base(message) { }
	}
}