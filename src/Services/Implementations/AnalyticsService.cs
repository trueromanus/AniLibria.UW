namespace Anilibria.Services.Implementations {

	/// <summary>
	/// Analitics service for tracking information about application.
	/// </summary>
	public class AnalyticsService : IAnalyticsService {

		public void TrackEvent ( string eventName , string parameterName , string parameterValue ) {
		}

		/// <summary>
		/// Track event with single parameter.
		/// </summary>
		/// <param name="eventName">Event name.</param>
		/// <param name="parameterName">Parameter name.</param>
		/// <param name="parameterValue">Parameter value.</param>
		public static void TrackEventWithSingleParameter ( string eventName , string parameterName , string parameterValue ) {
		}

	}

}
