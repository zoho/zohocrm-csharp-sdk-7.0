using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class Node : Model
	{
		private int? posY;
		private int? posX;
		private bool? startNode;
		private Screen screen;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? PosY
		{
			/// <summary>The method to get the posY</summary>
			/// <returns>int? representing the posY</returns>
			get
			{
				return  this.posY;

			}
			/// <summary>The method to set the value to posY</summary>
			/// <param name="posY">int?</param>
			set
			{
				 this.posY=value;

				 this.keyModified["pos_y"] = 1;

			}
		}

		public int? PosX
		{
			/// <summary>The method to get the posX</summary>
			/// <returns>int? representing the posX</returns>
			get
			{
				return  this.posX;

			}
			/// <summary>The method to set the value to posX</summary>
			/// <param name="posX">int?</param>
			set
			{
				 this.posX=value;

				 this.keyModified["pos_x"] = 1;

			}
		}

		public bool? StartNode
		{
			/// <summary>The method to get the startNode</summary>
			/// <returns>bool? representing the startNode</returns>
			get
			{
				return  this.startNode;

			}
			/// <summary>The method to set the value to startNode</summary>
			/// <param name="startNode">bool?</param>
			set
			{
				 this.startNode=value;

				 this.keyModified["start_node"] = 1;

			}
		}

		public Screen Screen
		{
			/// <summary>The method to get the screen</summary>
			/// <returns>Instance of Screen</returns>
			get
			{
				return  this.screen;

			}
			/// <summary>The method to set the value to screen</summary>
			/// <param name="screen">Instance of Screen</param>
			set
			{
				 this.screen=value;

				 this.keyModified["screen"] = 1;

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