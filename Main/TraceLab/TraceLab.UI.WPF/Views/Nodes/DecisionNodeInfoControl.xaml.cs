﻿// TraceLab - Software Traceability Instrument to Facilitate and Empower Traceability Research
// Copyright (C) 2012-2013 CoEST - National Science Foundation MRI-R2 Grant # CNS: 0959924
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see<http://www.gnu.org/licenses/>.


using TraceLab.Core.Experiments;
using TraceLab.UI.WPF.ViewModels;
using System.Collections.Generic;
using System;
using TraceLab.Core.Components;
using System.Windows.Input;
using System.Windows;
using TraceLab.UI.WPF.Commands;

namespace TraceLab.UI.WPF.Views.Nodes
{
    /// <summary>
    /// Interaction logic for DecisionNodeInfoControl.xaml
    /// </summary>
    public partial class DecisionNodeInfoControl : DecisionInfoControlBase
    {
        #region Constructing and loading

        public DecisionNodeInfoControl() : base()
        {
            InitializeComponent();

            //attach event handler
            DecisionCodeRichTextBox.FillItemsNeeded += OnFillItemsNeeded;

            AddPasteHandler();
            AddCopyDataEventHandler();
        }

        #endregion

        #region UI Elements

        protected override TraceLab.UI.WPF.Controls.RichTextBoxWithIntellisense DecisionCodeRichTextBox
        {
            get { return decisionCodeRichTextBox; }
        }

        #endregion
    }
}