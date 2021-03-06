﻿/* 
 * Copyright (c) 2010, Andriy Syrov
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are permitted provided 
 * that the following conditions are met:
 * 
 * Redistributions of source code must retain the above copyright notice, this list of conditions and the 
 * following disclaimer.
 * 
 * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and 
 * the following disclaimer in the documentation and/or other materials provided with the distribution.
 *
 * Neither the name of Andriy Syrov nor the names of his contributors may be used to endorse or promote 
 * products derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED 
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
 * PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY 
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED 
 * TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, 
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN 
 * IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 
 *   
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Browser;

namespace TimelineLibrary
{
    public partial class EventDetailsWindow : ChildWindow
    {
        public int                                      MOREINFO_WIDTH = 800;
        public int                                      MOREINFO_HEIGHT = 600;

        public EventDetailsWindow(
        )
        {
            InitializeComponent();
        }

        private void OnOkClick(
            object                                      sender, 
            RoutedEventArgs                             e
        )
        {
            this.DialogResult = true;
        }

        private void OnHyperlinkButtonClick(
            object                                      sender, 
            RoutedEventArgs                             e
        )
        {
            TimelineDisplayEvent                        ev;
            HtmlPopupWindowOptions                      options;

            ev = (TimelineDisplayEvent) this.DataContext;

            if (!String.IsNullOrEmpty(ev.Event.Link))
            {
                options = new HtmlPopupWindowOptions();
                options.Width = MOREINFO_WIDTH;
                options.Height = MOREINFO_HEIGHT;

                HtmlPage.PopupWindow(new Uri(ev.Event.Link), String.Empty, options); 
            }

        }
    }
}

