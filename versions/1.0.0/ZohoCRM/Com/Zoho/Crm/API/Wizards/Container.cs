using Com.Zoho.Crm.API.Layouts;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class Container : Model
	{
		private long? id;
		private Layouts.Layouts layout;
		private ChartData chartData;
		private List<Screen> screens;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public Layouts.Layouts Layout
		{
			/// <summary>The method to get the layout</summary>
			/// <returns>Instance of Layouts</returns>
			get
			{
				return  this.layout;

			}
			/// <summary>The method to set the value to layout</summary>
			/// <param name="layout">Instance of Layouts</param>
			set
			{
				 this.layout=value;

				 this.keyModified["layout"] = 1;

			}
		}

		public ChartData ChartData
		{
			/// <summary>The method to get the chartData</summary>
			/// <returns>Instance of ChartData</returns>
			get
			{
				return  this.chartData;

			}
			/// <summary>The method to set the value to chartData</summary>
			/// <param name="chartData">Instance of ChartData</param>
			set
			{
				 this.chartData=value;

				 this.keyModified["chart_data"] = 1;

			}
		}

		public List<Screen> Screens
		{
			/// <summary>The method to get the screens</summary>
			/// <returns>Instance of List<Screen></returns>
			get
			{
				return  this.screens;

			}
			/// <summary>The method to set the value to screens</summary>
			/// <param name="screens">Instance of List<Screen></param>
			set
			{
				 this.screens=value;

				 this.keyModified["screens"] = 1;

			}
		}

		/// <summary>The method to check if the user has modified the given key</summary>
		/// <param name="key">string</param>
		/// <returns>int? representing the modification</returns>
		public int? IsKeyModified(string key)
		{
			if((( this.keyModified.ContainsKey(key))))
			{
				return  this.keyModified[key];

			}
			return null;


		}

		/// <summary>The method to mark the given key as modified</summary>
		/// <param name="key">string</param>
		/// <param name="modification">int?</param>
		public void SetKeyModified(string key, int? modification)
		{
			 this.keyModified[key] = modification;


		}


	}
}