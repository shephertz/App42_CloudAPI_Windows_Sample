﻿#pragma checksum "D:\@KSH@Y\ZZ-APP42-SDK-SAMPLES\Windows-Sample\ServicesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9EE53A7F107600726A0C9E2C8443A16D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace App42Sample {
    
    
    public partial class ServicesPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot pivot;
        
        internal System.Windows.Controls.TextBlock PageTitle1;
        
        internal System.Windows.Controls.TextBlock UserOutput;
        
        internal System.Windows.Controls.Button createUser;
        
        internal System.Windows.Controls.Button authenticate;
        
        internal System.Windows.Controls.Button getUser;
        
        internal System.Windows.Controls.Button clear;
        
        internal System.Windows.Controls.Button deleteUser;
        
        internal System.Windows.Controls.TextBlock PageTitle2;
        
        internal System.Windows.Controls.TextBlock StorageOutput;
        
        internal System.Windows.Controls.Button InsertJSONDocumentWithJsonObject;
        
        internal System.Windows.Controls.Button UpdateDocByKeyValueWithJsonObject;
        
        internal System.Windows.Controls.Button FindDocumentByKeyValue;
        
        internal System.Windows.Controls.Button clearstorage;
        
        internal System.Windows.Controls.TextBlock PageTitle3;
        
        internal System.Windows.Controls.TextBlock gameOutput;
        
        internal System.Windows.Controls.Button CreateGame;
        
        internal System.Windows.Controls.Button SaveUserScore;
        
        internal System.Windows.Controls.Button LeaderBoard;
        
        internal System.Windows.Controls.Button clearGame;
        
        internal System.Windows.Controls.TextBlock footer;
        
        internal System.Windows.Controls.TextBlock PageTitle4;
        
        internal System.Windows.Controls.TextBlock uploadOutput;
        
        internal System.Windows.Controls.Button clearUpload;
        
        internal System.Windows.Controls.Button UploadFile;
        
        internal System.Windows.Controls.Button UploadFileForUser;
        
        internal System.Windows.Controls.Button GetFileByUser;
        
        internal System.Windows.Controls.Button RemoveFileByName;
        
        internal System.Windows.Controls.Button GetFileByName;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/App42Sample;component/ServicesPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("pivot")));
            this.PageTitle1 = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle1")));
            this.UserOutput = ((System.Windows.Controls.TextBlock)(this.FindName("UserOutput")));
            this.createUser = ((System.Windows.Controls.Button)(this.FindName("createUser")));
            this.authenticate = ((System.Windows.Controls.Button)(this.FindName("authenticate")));
            this.getUser = ((System.Windows.Controls.Button)(this.FindName("getUser")));
            this.clear = ((System.Windows.Controls.Button)(this.FindName("clear")));
            this.deleteUser = ((System.Windows.Controls.Button)(this.FindName("deleteUser")));
            this.PageTitle2 = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle2")));
            this.StorageOutput = ((System.Windows.Controls.TextBlock)(this.FindName("StorageOutput")));
            this.InsertJSONDocumentWithJsonObject = ((System.Windows.Controls.Button)(this.FindName("InsertJSONDocumentWithJsonObject")));
            this.UpdateDocByKeyValueWithJsonObject = ((System.Windows.Controls.Button)(this.FindName("UpdateDocByKeyValueWithJsonObject")));
            this.FindDocumentByKeyValue = ((System.Windows.Controls.Button)(this.FindName("FindDocumentByKeyValue")));
            this.clearstorage = ((System.Windows.Controls.Button)(this.FindName("clearstorage")));
            this.PageTitle3 = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle3")));
            this.gameOutput = ((System.Windows.Controls.TextBlock)(this.FindName("gameOutput")));
            this.CreateGame = ((System.Windows.Controls.Button)(this.FindName("CreateGame")));
            this.SaveUserScore = ((System.Windows.Controls.Button)(this.FindName("SaveUserScore")));
            this.LeaderBoard = ((System.Windows.Controls.Button)(this.FindName("LeaderBoard")));
            this.clearGame = ((System.Windows.Controls.Button)(this.FindName("clearGame")));
            this.footer = ((System.Windows.Controls.TextBlock)(this.FindName("footer")));
            this.PageTitle4 = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle4")));
            this.uploadOutput = ((System.Windows.Controls.TextBlock)(this.FindName("uploadOutput")));
            this.clearUpload = ((System.Windows.Controls.Button)(this.FindName("clearUpload")));
            this.UploadFile = ((System.Windows.Controls.Button)(this.FindName("UploadFile")));
            this.UploadFileForUser = ((System.Windows.Controls.Button)(this.FindName("UploadFileForUser")));
            this.GetFileByUser = ((System.Windows.Controls.Button)(this.FindName("GetFileByUser")));
            this.RemoveFileByName = ((System.Windows.Controls.Button)(this.FindName("RemoveFileByName")));
            this.GetFileByName = ((System.Windows.Controls.Button)(this.FindName("GetFileByName")));
        }
    }
}

