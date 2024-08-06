using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class ChartData : Model
	{
		private List<Node> nodes;
		private List<Connection> connections;
		private ButtonBackground colorPalette;
		private int? canvasWidth;
		private int? canvasHeight;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<Node> Nodes
		{
			/// <summary>The method to get the nodes</summary>
			/// <returns>Instance of List<Node></returns>
			get
			{
				return  this.nodes;

			}
			/// <summary>The method to set the value to nodes</summary>
			/// <param name="nodes">Instance of List<Node></param>
			set
			{
				 this.nodes=value;

				 this.keyModified["nodes"] = 1;

			}
		}

		public List<Connection> Connections
		{
			/// <summary>The method to get the connections</summary>
			/// <returns>Instance of List<Connection></returns>
			get
			{
				return  this.connections;

			}
			/// <summary>The method to set the value to connections</summary>
			/// <param name="connections">Instance of List<Connection></param>
			set
			{
				 this.connections=value;

				 this.keyModified["connections"] = 1;

			}
		}

		public ButtonBackground ColorPalette
		{
			/// <summary>The method to get the colorPalette</summary>
			/// <returns>Instance of ButtonBackground</returns>
			get
			{
				return  this.colorPalette;

			}
			/// <summary>The method to set the value to colorPalette</summary>
			/// <param name="colorPalette">Instance of ButtonBackground</param>
			set
			{
				 this.colorPalette=value;

				 this.keyModified["color_palette"] = 1;

			}
		}

		public int? CanvasWidth
		{
			/// <summary>The method to get the canvasWidth</summary>
			/// <returns>int? representing the canvasWidth</returns>
			get
			{
				return  this.canvasWidth;

			}
			/// <summary>The method to set the value to canvasWidth</summary>
			/// <param name="canvasWidth">int?</param>
			set
			{
				 this.canvasWidth=value;

				 this.keyModified["canvas_width"] = 1;

			}
		}

		public int? CanvasHeight
		{
			/// <summary>The method to get the canvasHeight</summary>
			/// <returns>int? representing the canvasHeight</returns>
			get
			{
				return  this.canvasHeight;

			}
			/// <summary>The method to set the value to canvasHeight</summary>
			/// <param name="canvasHeight">int?</param>
			set
			{
				 this.canvasHeight=value;

				 this.keyModified["canvas_height"] = 1;

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