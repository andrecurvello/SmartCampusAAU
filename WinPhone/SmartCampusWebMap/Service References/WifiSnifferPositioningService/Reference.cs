//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 5/14/2013 11:27:10 AM
namespace SmartCampusWebMap.WifiSnifferPositioningService
{
    
    /// <summary>
    /// There are no comments for SnifferModel in the schema.
    /// </summary>
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public partial class SnifferModel : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new SnifferModel object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public SnifferModel(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("WifiSnifferPositioningService", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("SmartCampusWebMap.WifiSnifferPositioningService", typeName.Substring(29)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("SmartCampusWebMap.WifiSnifferPositioningService", global::System.StringComparison.Ordinal))
            {
                return string.Concat("WifiSnifferPositioningService.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for PositionEstimates in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<PositionEstimate> PositionEstimates
        {
            get
            {
                if ((this._PositionEstimates == null))
                {
                    this._PositionEstimates = base.CreateQuery<PositionEstimate>("PositionEstimates");
                }
                return this._PositionEstimates;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<PositionEstimate> _PositionEstimates;
        /// <summary>
        /// There are no comments for PositionEstimates in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToPositionEstimates(PositionEstimate positionEstimate)
        {
            base.AddObject("PositionEstimates", positionEstimate);
        }
    }
    /// <summary>
    /// There are no comments for WifiSnifferPositioningService.PositionEstimate in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("PositionEstimates")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ID")]
    public partial class PositionEstimate : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PositionEstimate object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        /// <param name="building_ID">Initial value of Building_ID.</param>
        /// <param name="vertexID">Initial value of VertexID.</param>
        /// <param name="latitude">Initial value of Latitude.</param>
        /// <param name="longitude">Initial value of Longitude.</param>
        /// <param name="altitude">Initial value of Altitude.</param>
        /// <param name="time">Initial value of Time.</param>
        /// <param name="accuracy">Initial value of Accuracy.</param>
        /// <param name="speed">Initial value of Speed.</param>
        /// <param name="bearing">Initial value of Bearing.</param>
        /// <param name="hasAccuracy">Initial value of HasAccuracy.</param>
        /// <param name="hasSpeed">Initial value of HasSpeed.</param>
        /// <param name="hasBearing">Initial value of HasBearing.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static PositionEstimate CreatePositionEstimate(int ID, int building_ID, int vertexID, double latitude, double longitude, double altitude, global::System.DateTime time, double accuracy, double speed, double bearing, bool hasAccuracy, bool hasSpeed, bool hasBearing)
        {
            PositionEstimate positionEstimate = new PositionEstimate();
            positionEstimate.ID = ID;
            positionEstimate.Building_ID = building_ID;
            positionEstimate.VertexID = vertexID;
            positionEstimate.Latitude = latitude;
            positionEstimate.Longitude = longitude;
            positionEstimate.Altitude = altitude;
            positionEstimate.Time = time;
            positionEstimate.Accuracy = accuracy;
            positionEstimate.Speed = speed;
            positionEstimate.Bearing = bearing;
            positionEstimate.HasAccuracy = hasAccuracy;
            positionEstimate.HasSpeed = hasSpeed;
            positionEstimate.HasBearing = hasBearing;
            return positionEstimate;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
                this.OnPropertyChanged("ID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Building_ID in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Building_ID
        {
            get
            {
                return this._Building_ID;
            }
            set
            {
                this.OnBuilding_IDChanging(value);
                this._Building_ID = value;
                this.OnBuilding_IDChanged();
                this.OnPropertyChanged("Building_ID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Building_ID;
        partial void OnBuilding_IDChanging(int value);
        partial void OnBuilding_IDChanged();
        /// <summary>
        /// There are no comments for Property VertexID in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int VertexID
        {
            get
            {
                return this._VertexID;
            }
            set
            {
                this.OnVertexIDChanging(value);
                this._VertexID = value;
                this.OnVertexIDChanged();
                this.OnPropertyChanged("VertexID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _VertexID;
        partial void OnVertexIDChanging(int value);
        partial void OnVertexIDChanged();
        /// <summary>
        /// There are no comments for Property Latitude in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public double Latitude
        {
            get
            {
                return this._Latitude;
            }
            set
            {
                this.OnLatitudeChanging(value);
                this._Latitude = value;
                this.OnLatitudeChanged();
                this.OnPropertyChanged("Latitude");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private double _Latitude;
        partial void OnLatitudeChanging(double value);
        partial void OnLatitudeChanged();
        /// <summary>
        /// There are no comments for Property Longitude in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public double Longitude
        {
            get
            {
                return this._Longitude;
            }
            set
            {
                this.OnLongitudeChanging(value);
                this._Longitude = value;
                this.OnLongitudeChanged();
                this.OnPropertyChanged("Longitude");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private double _Longitude;
        partial void OnLongitudeChanging(double value);
        partial void OnLongitudeChanged();
        /// <summary>
        /// There are no comments for Property Altitude in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public double Altitude
        {
            get
            {
                return this._Altitude;
            }
            set
            {
                this.OnAltitudeChanging(value);
                this._Altitude = value;
                this.OnAltitudeChanged();
                this.OnPropertyChanged("Altitude");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private double _Altitude;
        partial void OnAltitudeChanging(double value);
        partial void OnAltitudeChanged();
        /// <summary>
        /// There are no comments for Property Provider in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Provider
        {
            get
            {
                return this._Provider;
            }
            set
            {
                this.OnProviderChanging(value);
                this._Provider = value;
                this.OnProviderChanged();
                this.OnPropertyChanged("Provider");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Provider;
        partial void OnProviderChanging(string value);
        partial void OnProviderChanged();
        /// <summary>
        /// There are no comments for Property Time in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime Time
        {
            get
            {
                return this._Time;
            }
            set
            {
                this.OnTimeChanging(value);
                this._Time = value;
                this.OnTimeChanged();
                this.OnPropertyChanged("Time");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _Time;
        partial void OnTimeChanging(global::System.DateTime value);
        partial void OnTimeChanged();
        /// <summary>
        /// There are no comments for Property Accuracy in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public double Accuracy
        {
            get
            {
                return this._Accuracy;
            }
            set
            {
                this.OnAccuracyChanging(value);
                this._Accuracy = value;
                this.OnAccuracyChanged();
                this.OnPropertyChanged("Accuracy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private double _Accuracy;
        partial void OnAccuracyChanging(double value);
        partial void OnAccuracyChanged();
        /// <summary>
        /// There are no comments for Property Speed in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public double Speed
        {
            get
            {
                return this._Speed;
            }
            set
            {
                this.OnSpeedChanging(value);
                this._Speed = value;
                this.OnSpeedChanged();
                this.OnPropertyChanged("Speed");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private double _Speed;
        partial void OnSpeedChanging(double value);
        partial void OnSpeedChanged();
        /// <summary>
        /// There are no comments for Property Bearing in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public double Bearing
        {
            get
            {
                return this._Bearing;
            }
            set
            {
                this.OnBearingChanging(value);
                this._Bearing = value;
                this.OnBearingChanged();
                this.OnPropertyChanged("Bearing");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private double _Bearing;
        partial void OnBearingChanging(double value);
        partial void OnBearingChanged();
        /// <summary>
        /// There are no comments for Property HasAccuracy in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool HasAccuracy
        {
            get
            {
                return this._HasAccuracy;
            }
            set
            {
                this.OnHasAccuracyChanging(value);
                this._HasAccuracy = value;
                this.OnHasAccuracyChanged();
                this.OnPropertyChanged("HasAccuracy");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _HasAccuracy;
        partial void OnHasAccuracyChanging(bool value);
        partial void OnHasAccuracyChanged();
        /// <summary>
        /// There are no comments for Property HasSpeed in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool HasSpeed
        {
            get
            {
                return this._HasSpeed;
            }
            set
            {
                this.OnHasSpeedChanging(value);
                this._HasSpeed = value;
                this.OnHasSpeedChanged();
                this.OnPropertyChanged("HasSpeed");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _HasSpeed;
        partial void OnHasSpeedChanging(bool value);
        partial void OnHasSpeedChanged();
        /// <summary>
        /// There are no comments for Property HasBearing in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool HasBearing
        {
            get
            {
                return this._HasBearing;
            }
            set
            {
                this.OnHasBearingChanging(value);
                this._HasBearing = value;
                this.OnHasBearingChanged();
                this.OnPropertyChanged("HasBearing");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _HasBearing;
        partial void OnHasBearingChanging(bool value);
        partial void OnHasBearingChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
