using System;
using System.Collections.Generic;
using Gtk;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.GtkSharp;
using OxyPlot.Series;

namespace AppProject
{
	public class Statistika
	{
		
		public static VBox StatistikaDatum(List<AktivnostKorisnika> listak, DateTime datumOd, DateTime datumDo)
		{
			var items = new List<ColumnItem>();
			var kat = new List<string>();
			var list = listak;

			foreach (var x in list)
			{
				var b = new ColumnItem(x.Potrosnja);
				items.Add(b);
				kat.Add(x.Naziv);
			}

			if (list.Count > 1)
			{
				int i = 0;
				var listaBoja = OxyPalettes.Jet(list.Count).Colors;
				foreach (ColumnItem cI in items)
				{
					cI.Color = listaBoja[i];
					i++;
				}
			}


			var barSeries = new ColumnSeries
			{
				ItemsSource = items,
				LabelPlacement = LabelPlacement.Base,
				LabelFormatString = "{0:,00} kcal"
			};


			var model = new PlotModel { Title = "Statistika za razdoblje: " + datumOd.ToString("dd.MM.yyyy") + " - " + datumDo.ToString("dd.MM.yyyy") };

			model.Series.Add(barSeries);

			model.Axes.Add(new CategoryAxis
			{
				Position = AxisPosition.Bottom,
				Key = "Aktivnost",
				ItemsSource = kat
			});

			model.Axes.Add(new LinearAxis
			{
				Position = AxisPosition.Left,
				Minimum = 0
			});

			model.PlotAreaBackground = OxyColors.AliceBlue;
			var pv = new PlotView();
			pv.Model = model;
			var v = new VBox();
			v.Add(pv);
			return v;
		}

		public static VBox StatistikaTip(List<AktivnostKorisnika> listak, string tip)
		{
			var items = new List<ColumnItem>();
			var kat = new List<string>();
			var list = listak;

			foreach (var x in list)
			{
				var b = new ColumnItem(x.Potrosnja);
				items.Add(b);
				kat.Add(x.Tip);
			}

			if (list.Count > 1)
			{
				int i = 0;
				var listaBoja = OxyPalettes.Jet(list.Count).Colors;
				foreach (ColumnItem cI in items)
				{
					cI.Color = listaBoja[i];
					i++;
				}
			}


			var barSeries = new ColumnSeries
			{
				ItemsSource = items,
				LabelPlacement = LabelPlacement.Base,
				LabelFormatString = "{0:,00} kcal"
			};


			var model = new PlotModel { Title = "Statistika za tip aktivnosti: " + tip };

			model.Series.Add(barSeries);

			model.Axes.Add(new CategoryAxis
			{
				Position = AxisPosition.Bottom,
				Key = "Tip aktivnosti",
				ItemsSource = kat
			});

			model.Axes.Add(new LinearAxis
			{
				Position = AxisPosition.Left,
				Minimum = 0
			});

			model.PlotAreaBackground = OxyColors.AliceBlue;
			var pv = new PlotView();
			pv.Model = model;
			var v = new VBox();
			v.Add(pv);
			return v;
		}
	}
}
