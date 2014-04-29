﻿#region License

// Copyright (c) 2007 - 2014, Northwestern University, Vladimir Kleper, Skip Talbot
// and Pattanasak Mongkolwat.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
//
//   Redistributions of source code must retain the above copyright notice,
//   this list of conditions and the following disclaimer.
//
//   Redistributions in binary form must reproduce the above copyright notice,
//   this list of conditions and the following disclaimer in the documentation
//   and/or other materials provided with the distribution.
//
//   Neither the name of the National Cancer Institute nor Northwestern University
//   nor the names of its contributors may be used to endorse or promote products
//   derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#endregion

using System.Globalization;
using System.Windows.Controls;
using AIM.Annotation.TemplateTree;

namespace AIM.Annotation.View.WinForms.Wpf
{
	/// <summary>
	/// Interaction logic for CharacteristicQuantificationNumericalWpfControl.xaml
	/// </summary>
	public partial class CharacteristicQuantificationNumericalWpfControl : UserControl
	{
		private static readonly OperatorNameValuePair[] _availableOperators =
			new[]
				{
					new OperatorNameValuePair(null, null),
					new OperatorNameValuePair("=", "Equal"),
					new OperatorNameValuePair("!=", "NotEqual"),
					new OperatorNameValuePair("<", "LessThan"),
					new OperatorNameValuePair("<=", "LessThanEqual"),
					new OperatorNameValuePair(">", "GreaterThan"),
					new OperatorNameValuePair(">=", "GreaterThanEqual")
				};

		public CharacteristicQuantificationNumericalWpfControl(Numerical numerical)
		{
			InitializeComponent();

			_ddlComparisonOperator.ItemsSource = _availableOperators;

			_lblUcumString.Content = numerical.UcumString;

			_txtValue.Text = numerical.Value.ToString(CultureInfo.CurrentCulture);
		}

		internal class OperatorNameValuePair
		{
			public string Name { get; private set; }
			public string Value { get; private set; }

			public OperatorNameValuePair(string name, string value)
			{
				Name = name;
				Value = value;
			}

			public override string ToString()
			{
				return Value == null ? "---" : Name;
			}
		}
	}
}
