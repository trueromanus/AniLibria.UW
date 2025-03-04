using System.Collections.Generic;

namespace Anilibria.Services.PresentationClasses {

	/// <summary>
	/// Schedule day model.
	/// </summary>
	public class ScheduleDayModel {

		/// <summary>
		/// Day.
		/// </summary>
		public string Day
		{
			get;
			set;
		}

		/// <summary>
		/// Day.
		/// </summary>
		public IEnumerable<ScheduleModel> Items
		{
			get;
			set;
		}

	}

}
