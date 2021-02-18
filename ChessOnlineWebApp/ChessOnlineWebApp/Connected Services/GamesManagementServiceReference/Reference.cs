﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChessOnlineWebApp.GamesManagementServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Game", Namespace="http://schemas.datacontract.org/2004/07/GamesManagementService")]
    [System.SerializableAttribute()]
    public partial class Game : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long GameIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GameStringField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ChessOnlineWebApp.GamesManagementServiceReference.Game.Player PlayedAsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long GameId {
            get {
                return this.GameIdField;
            }
            set {
                if ((this.GameIdField.Equals(value) != true)) {
                    this.GameIdField = value;
                    this.RaisePropertyChanged("GameId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GameString {
            get {
                return this.GameStringField;
            }
            set {
                if ((object.ReferenceEquals(this.GameStringField, value) != true)) {
                    this.GameStringField = value;
                    this.RaisePropertyChanged("GameString");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ChessOnlineWebApp.GamesManagementServiceReference.Game.Player PlayedAs {
            get {
                return this.PlayedAsField;
            }
            set {
                if ((this.PlayedAsField.Equals(value) != true)) {
                    this.PlayedAsField = value;
                    this.RaisePropertyChanged("PlayedAs");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="Game.Player", Namespace="http://schemas.datacontract.org/2004/07/GamesManagementService")]
        public enum Player : int {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            White = 0,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Black = 1,
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GamesManagementFault", Namespace="http://schemas.datacontract.org/2004/07/GamesManagementService")]
    [System.SerializableAttribute()]
    public partial class GamesManagementFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GamesManagementServiceReference.IGamesManagementService")]
    public interface IGamesManagementService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGamesManagementService/SaveGame", ReplyAction="http://tempuri.org/IGamesManagementService/SaveGameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChessOnlineWebApp.GamesManagementServiceReference.GamesManagementFault), Action="http://tempuri.org/IGamesManagementService/SaveGameGamesManagementFaultFault", Name="GamesManagementFault", Namespace="http://schemas.datacontract.org/2004/07/GamesManagementService")]
        void SaveGame(ChessOnlineWebApp.GamesManagementServiceReference.Game game, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGamesManagementService/SaveGame", ReplyAction="http://tempuri.org/IGamesManagementService/SaveGameResponse")]
        System.Threading.Tasks.Task SaveGameAsync(ChessOnlineWebApp.GamesManagementServiceReference.Game game, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGamesManagementService/GetAllSavedGames", ReplyAction="http://tempuri.org/IGamesManagementService/GetAllSavedGamesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChessOnlineWebApp.GamesManagementServiceReference.GamesManagementFault), Action="http://tempuri.org/IGamesManagementService/GetAllSavedGamesGamesManagementFaultFa" +
            "ult", Name="GamesManagementFault", Namespace="http://schemas.datacontract.org/2004/07/GamesManagementService")]
        ChessOnlineWebApp.GamesManagementServiceReference.Game[] GetAllSavedGames(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGamesManagementService/GetAllSavedGames", ReplyAction="http://tempuri.org/IGamesManagementService/GetAllSavedGamesResponse")]
        System.Threading.Tasks.Task<ChessOnlineWebApp.GamesManagementServiceReference.Game[]> GetAllSavedGamesAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGamesManagementService/DeleteGame", ReplyAction="http://tempuri.org/IGamesManagementService/DeleteGameResponse")]
        void DeleteGame(ChessOnlineWebApp.GamesManagementServiceReference.Game game, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGamesManagementService/DeleteGame", ReplyAction="http://tempuri.org/IGamesManagementService/DeleteGameResponse")]
        System.Threading.Tasks.Task DeleteGameAsync(ChessOnlineWebApp.GamesManagementServiceReference.Game game, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGamesManagementService/FindMatch", ReplyAction="http://tempuri.org/IGamesManagementService/FindMatchResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChessOnlineWebApp.GamesManagementServiceReference.GamesManagementFault), Action="http://tempuri.org/IGamesManagementService/FindMatchGamesManagementFaultFault", Name="GamesManagementFault", Namespace="http://schemas.datacontract.org/2004/07/GamesManagementService")]
        string FindMatch(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGamesManagementService/FindMatch", ReplyAction="http://tempuri.org/IGamesManagementService/FindMatchResponse")]
        System.Threading.Tasks.Task<string> FindMatchAsync(string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGamesManagementServiceChannel : ChessOnlineWebApp.GamesManagementServiceReference.IGamesManagementService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GamesManagementServiceClient : System.ServiceModel.ClientBase<ChessOnlineWebApp.GamesManagementServiceReference.IGamesManagementService>, ChessOnlineWebApp.GamesManagementServiceReference.IGamesManagementService {
        
        public GamesManagementServiceClient() {
        }
        
        public GamesManagementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GamesManagementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GamesManagementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GamesManagementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SaveGame(ChessOnlineWebApp.GamesManagementServiceReference.Game game, string token) {
            base.Channel.SaveGame(game, token);
        }
        
        public System.Threading.Tasks.Task SaveGameAsync(ChessOnlineWebApp.GamesManagementServiceReference.Game game, string token) {
            return base.Channel.SaveGameAsync(game, token);
        }
        
        public ChessOnlineWebApp.GamesManagementServiceReference.Game[] GetAllSavedGames(string token) {
            return base.Channel.GetAllSavedGames(token);
        }
        
        public System.Threading.Tasks.Task<ChessOnlineWebApp.GamesManagementServiceReference.Game[]> GetAllSavedGamesAsync(string token) {
            return base.Channel.GetAllSavedGamesAsync(token);
        }
        
        public void DeleteGame(ChessOnlineWebApp.GamesManagementServiceReference.Game game, string token) {
            base.Channel.DeleteGame(game, token);
        }
        
        public System.Threading.Tasks.Task DeleteGameAsync(ChessOnlineWebApp.GamesManagementServiceReference.Game game, string token) {
            return base.Channel.DeleteGameAsync(game, token);
        }
        
        public string FindMatch(string token) {
            return base.Channel.FindMatch(token);
        }
        
        public System.Threading.Tasks.Task<string> FindMatchAsync(string token) {
            return base.Channel.FindMatchAsync(token);
        }
    }
}
