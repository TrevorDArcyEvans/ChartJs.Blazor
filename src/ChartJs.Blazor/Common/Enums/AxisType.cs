﻿namespace ChartJs.Blazor.Common.Enums
{
    /// <summary>
    /// As per documentation <a href="https://www.chartjs.org/docs/latest/axes/cartesian/">here (Chart.js)</a>.
    /// </summary>
    public sealed class AxisType : StringEnum
    {
        /// <summary>
        /// The linear scale is use to chart numerical data.
        /// As the name suggests, linear interpolation is used to determine where a value lies on the axis.
        /// <para>Can be used both for Radial and for Cartesian Axes</para>
        /// <para>For cartesian: It can be placed on either the x or y axis.
        /// The scatter chart type automatically configures a line chart to use one of these scales for the x axis. </para>
        /// </summary>
        public static AxisType Linear => new AxisType("linear");

        /// <summary>
        /// The logarithmic scale is use to chart numerical data. It can be placed on either the x or y axis.
        /// As the name suggests, logarithmic interpolation is used to determine where a value lies on the axis.
        /// </summary>
        public static AxisType Logarithmic => new AxisType("logarithmic");

        /// <summary>
        /// If global configuration is used, labels are drawn from one of the label arrays included in the chart data (<see cref="ChartData"/>).
        /// If only <see cref="ChartData.Labels"/> is defined, this will be used. If <see cref="ChartData.XLabels"/> is defined and the axis is horizontal, this will be used.
        /// Similarly, if <see cref="ChartData.YLabels"/> is defined and the axis is vertical, this property will be used.
        /// Using both xLabels and yLabels together can create a chart that uses strings for both the X and Y axes.
        /// Specifying any of the settings above defines the x axis as type: <see cref="Category" /> if not defined otherwise.
        /// <para>
        /// Note: The axes in this library are strongly typed and always contain a type so this inference only applies if you don't provide an axis in the options.
        /// </para>
        /// <para>
        /// For more fine-grained control of category labels it is also possible to add labels as part of the category axis definition (<see cref="Axes.Ticks.CategoryTicks.Labels"/>).
        /// Doing so does not apply the global defaults for the chart.
        /// </para>
        /// <para>See <a href="https://www.chartjs.org/docs/latest/axes/cartesian/category.html">here (Chart.js)</a>.</para>
        /// </summary>
        public static AxisType Category => new AxisType("category");

        /// <summary>
        /// The time scale is used to display times and dates.
        /// When building its ticks, it will automatically calculate the most comfortable unit base on the size of the scale.
        /// </summary>
        public static AxisType Time => new AxisType("time");

        public static AxisType Gantt => new AxisType("time-gantt");

        private AxisType(string stringRep) : base(stringRep) { }
    }
}
