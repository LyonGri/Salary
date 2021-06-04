using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	/// <summary>
	/// Класс для улучшения внешнего вида кнопок
	/// </summary>
	public static class ButtonLookImprovement
	{
		/// <summary>
		/// Улучшение внешнего вида кнопок
		/// </summary>
		/// <param name="buttons">Лист с кнопками</param>
		public static void ButtonNiceLook(List<Button> buttons)
		{
			foreach (var button in buttons)
			{
				ButtonImprovement(button);
			}
		}

		/// <summary>
		/// Наведение красоты у кнопок
		/// </summary>
		/// <param name="button">Кнопка</param>
		private static void ButtonImprovement(Button button)
		{
			button.FlatAppearance.BorderSize = 0;
			button.FlatStyle = FlatStyle.Flat;
		}		
	}
}
