using System;
using System.Linq;

namespace Janyee.Utilty {
	public static class ResponsiveControl {
		public static void ChangeFontSize(double width, double height, double area, double scala, Windows.UI.Xaml.Controls.TextBlock textBlock) {
			if (width * height > area) {
				textBlock.FontSize = width * height / scala;
				area = width * height;
			}
			else if (width * height < area) {
				textBlock.FontSize = width * height / scala > 1 ? width * height / scala : 10;
				area = width * height;
			}
		}

		public static void SetGridColumnByBreakpoints(Windows.UI.Xaml.Controls.Grid grid, double width) {
			// 不同窗口宽度有不同的列数，Breakpoints.Small 为一列，Breakpoints.Medium 为两列，Breakpoints.Large 为三列
			switch (GetBreakpoints(width)) {
				case Breakpoints.Small:
					if (grid.ColumnDefinitions.Count == 1) {
						// 不做任何处理
					}
					else if (grid.ColumnDefinitions.Count == 2) {
						grid.ColumnDefinitions.Remove(grid.ColumnDefinitions.Last());
					}
					else if (grid.ColumnDefinitions.Count == 3) {
						grid.ColumnDefinitions.Remove(grid.ColumnDefinitions.Last());
						grid.ColumnDefinitions.Remove(grid.ColumnDefinitions.Last());
					}
					else {
						throw new Exception($"发生未知错误，grid.ColumnDefinitions.Count: {grid.ColumnDefinitions.Count}");
					}
					break;
				case Breakpoints.Medium:
					if (grid.ColumnDefinitions.Count == 1) {
						grid.ColumnDefinitions.Add(new Windows.UI.Xaml.Controls.ColumnDefinition());
					}
					else if (grid.ColumnDefinitions.Count == 2) {
						// 不做任何处理
					}
					else if (grid.ColumnDefinitions.Count == 3) {
						grid.ColumnDefinitions.Remove(grid.ColumnDefinitions.Last());
					}
					else {
						throw new Exception($"发生未知错误，grid.ColumnDefinitions.Count: {grid.ColumnDefinitions.Count}");
					}
					break;
				case Breakpoints.Large:
					if (grid.ColumnDefinitions.Count == 1) {
						grid.ColumnDefinitions.Add(new Windows.UI.Xaml.Controls.ColumnDefinition());
						grid.ColumnDefinitions.Add(new Windows.UI.Xaml.Controls.ColumnDefinition());
					}
					else if (grid.ColumnDefinitions.Count == 2) {
						grid.ColumnDefinitions.Add(new Windows.UI.Xaml.Controls.ColumnDefinition());
					}
					else if (grid.ColumnDefinitions.Count == 3) {
						// 不做任何处理
					}
					else {
						throw new Exception($"发生未知错误，grid.ColumnDefinitions.Count: {grid.ColumnDefinitions.Count}");
					}
					break;
				default:
					throw new Exception($"发生未知错误，width: {width}");
			}
		}

		/// <summary>
		/// 判断宽度值处于哪一个 Breakpoints
		/// </summary>
		/// <param name="width">容器、窗口宽度</param>
		/// <see cref="https://docs.microsoft.com/en-us/windows/uwp/design/layout/screen-sizes-and-breakpoints-for-responsive-design"/>
		/// <exception cref="System.ArgumentOutOfRangeException">宽度小于等于0时抛出异常</exception>
		/// <returns></returns>
		public static Breakpoints GetBreakpoints(double width) {
			if (width > 0 && width <= 640) {
				return Breakpoints.Small;
			}
			else if (width > 640 && width <= 1007) {
				return Breakpoints.Medium;
			}
			else if (width > 1007) {
				return Breakpoints.Large;
			}
			else {
				throw new ArgumentOutOfRangeException();
			}
		}
	}

	public enum Breakpoints {
		Small,
		Medium,
		Large
	}
}
