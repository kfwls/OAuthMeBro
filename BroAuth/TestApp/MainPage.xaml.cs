﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using BroAuth.Twitter;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TestApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

	    protected override void OnNavigatedTo(NavigationEventArgs e)
	    {
		    PollTwitter();
	    }

	    public async void PollTwitter()
	    {
			var bro = new TwitterBro();
			await bro.Handshake(BroAuth.Secrets.ApiKey, BroAuth.Secrets.ApiSecret);
			var results = bro.GetMeTweets("peanuts", "recent", 20);
		    
	    }
    }
}
