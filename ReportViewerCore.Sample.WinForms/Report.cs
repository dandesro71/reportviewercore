﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReportViewerCore
{
	class Report
	{
		public static void Load(LocalReport report)
		{
			var items = new[] { new ReportItem { Description = "Widget 6000", Price = .111111m, Qty = 1 }, new ReportItem { Description = "Gizmo MAX", Price = 0.22222m, Qty = 25 } };
			var parameters = new[] { new ReportParameter("Title", "Invoice 4/2020") };
			using var fs = new FileStream("Report.rdlc", FileMode.Open);
			report.LoadReportDefinition(fs);
			report.DataSources.Add(new ReportDataSource("Items", items));
			report.SetParameters(parameters);
		}
	}
}
