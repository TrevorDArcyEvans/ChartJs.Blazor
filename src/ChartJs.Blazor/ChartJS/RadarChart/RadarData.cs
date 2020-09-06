﻿using System.Collections.Generic;
using ChartJs.Blazor.ChartJS.Common;

namespace ChartJs.Blazor.ChartJS.RadarChart
{
    /// <summary>
    /// Represents the data-subconfig of a <see cref="RadarConfig"/>.
    /// </summary>
    public class RadarData
    {
        /// <summary>
        /// Gets the labels the chart will use.
        /// </summary>
        public IList<string> Labels { get; } = new List<string>();

        /// <summary>
        /// Gets the datasets displayed in this chart.
        /// </summary>
        public IList<IDataset> Datasets { get; } = new List<IDataset>();
    }
}
