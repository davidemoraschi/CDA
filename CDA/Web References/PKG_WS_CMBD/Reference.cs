﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.42.
// 
#pragma warning disable 1591

namespace CDA.PKG_WS_CMBD {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PKG_WS_CMBDBinding", Namespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD")]
    public partial class PKG_WS_CMBDService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback WS005_EPISODIO_POR_NADMIOperationCompleted;
        
        private System.Threading.SendOrPostCallback WS004_EPISODIO_POR_NEPISOperationCompleted;
        
        private System.Threading.SendOrPostCallback WS003_EPISODIOS_POR_NDNIOperationCompleted;
        
        private System.Threading.SendOrPostCallback WS002_EPISODIOS_POR_NHISTOperationCompleted;
        
        private System.Threading.SendOrPostCallback WS001_EPISODIOS_POR_NUHSAOperationCompleted;
        
        private System.Threading.SendOrPostCallback WRITE_LOPDOperationCompleted;
        
        private System.Threading.SendOrPostCallback START_UPOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PKG_WS_CMBDService() {
            this.Url = global::CDA.Properties.Settings.Default.CDA_PKG_WS_CMBD_PKG_WS_CMBDService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event WS005_EPISODIO_POR_NADMICompletedEventHandler WS005_EPISODIO_POR_NADMICompleted;
        
        /// <remarks/>
        public event WS004_EPISODIO_POR_NEPISCompletedEventHandler WS004_EPISODIO_POR_NEPISCompleted;
        
        /// <remarks/>
        public event WS003_EPISODIOS_POR_NDNICompletedEventHandler WS003_EPISODIOS_POR_NDNICompleted;
        
        /// <remarks/>
        public event WS002_EPISODIOS_POR_NHISTCompletedEventHandler WS002_EPISODIOS_POR_NHISTCompleted;
        
        /// <remarks/>
        public event WS001_EPISODIOS_POR_NUHSACompletedEventHandler WS001_EPISODIOS_POR_NUHSACompleted;
        
        /// <remarks/>
        public event WRITE_LOPDCompletedEventHandler WRITE_LOPDCompleted;
        
        /// <remarks/>
        public event START_UPCompletedEventHandler START_UPCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WS005_EPISODIO_POR_NADMI", RequestElementName="WS005_EPISODIO_POR_NADMIInput", RequestNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ResponseElementName="WS005_EPISODIO_POR_NADMIOutput", ResponseNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("P_RESULTADO")]
        public System.Xml.XmlElement WS005_EPISODIO_POR_NADMI([System.Xml.Serialization.XmlElementAttribute("P_RESULTADO-XMLTYPE-OUT")] WS005_EPISODIO_POR_NADMIInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, [System.Xml.Serialization.XmlElementAttribute("P_QUIENERES-VARCHAR2-IN")] string P_QUIENERESVARCHAR2IN, [System.Xml.Serialization.XmlElementAttribute("P_NADMI-NUMBER-IN")] double P_NADMINUMBERIN, [System.Xml.Serialization.XmlElementAttribute("P_CAMPOS-VARCHAR2-OUT")] WS005_EPISODIO_POR_NADMIInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT, out string P_CAMPOS) {
            object[] results = this.Invoke("WS005_EPISODIO_POR_NADMI", new object[] {
                        P_RESULTADOXMLTYPEOUT,
                        P_QUIENERESVARCHAR2IN,
                        P_NADMINUMBERIN,
                        P_CAMPOSVARCHAR2OUT});
            P_CAMPOS = ((string)(results[1]));
            return ((System.Xml.XmlElement)(results[0]));
        }
        
        /// <remarks/>
        public void WS005_EPISODIO_POR_NADMIAsync(WS005_EPISODIO_POR_NADMIInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, string P_QUIENERESVARCHAR2IN, double P_NADMINUMBERIN, WS005_EPISODIO_POR_NADMIInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT) {
            this.WS005_EPISODIO_POR_NADMIAsync(P_RESULTADOXMLTYPEOUT, P_QUIENERESVARCHAR2IN, P_NADMINUMBERIN, P_CAMPOSVARCHAR2OUT, null);
        }
        
        /// <remarks/>
        public void WS005_EPISODIO_POR_NADMIAsync(WS005_EPISODIO_POR_NADMIInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, string P_QUIENERESVARCHAR2IN, double P_NADMINUMBERIN, WS005_EPISODIO_POR_NADMIInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT, object userState) {
            if ((this.WS005_EPISODIO_POR_NADMIOperationCompleted == null)) {
                this.WS005_EPISODIO_POR_NADMIOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWS005_EPISODIO_POR_NADMIOperationCompleted);
            }
            this.InvokeAsync("WS005_EPISODIO_POR_NADMI", new object[] {
                        P_RESULTADOXMLTYPEOUT,
                        P_QUIENERESVARCHAR2IN,
                        P_NADMINUMBERIN,
                        P_CAMPOSVARCHAR2OUT}, this.WS005_EPISODIO_POR_NADMIOperationCompleted, userState);
        }
        
        private void OnWS005_EPISODIO_POR_NADMIOperationCompleted(object arg) {
            if ((this.WS005_EPISODIO_POR_NADMICompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WS005_EPISODIO_POR_NADMICompleted(this, new WS005_EPISODIO_POR_NADMICompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WS004_EPISODIO_POR_NEPIS", RequestElementName="WS004_EPISODIO_POR_NEPISInput", RequestNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ResponseElementName="WS004_EPISODIO_POR_NEPISOutput", ResponseNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("P_RESULTADO")]
        public System.Xml.XmlElement WS004_EPISODIO_POR_NEPIS([System.Xml.Serialization.XmlElementAttribute("P_RESULTADO-XMLTYPE-OUT")] WS004_EPISODIO_POR_NEPISInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, [System.Xml.Serialization.XmlElementAttribute("P_QUIENERES-VARCHAR2-IN")] string P_QUIENERESVARCHAR2IN, [System.Xml.Serialization.XmlElementAttribute("P_NEPIS-NUMBER-IN")] double P_NEPISNUMBERIN, [System.Xml.Serialization.XmlElementAttribute("P_CAMPOS-VARCHAR2-OUT")] WS004_EPISODIO_POR_NEPISInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT, out string P_CAMPOS) {
            object[] results = this.Invoke("WS004_EPISODIO_POR_NEPIS", new object[] {
                        P_RESULTADOXMLTYPEOUT,
                        P_QUIENERESVARCHAR2IN,
                        P_NEPISNUMBERIN,
                        P_CAMPOSVARCHAR2OUT});
            P_CAMPOS = ((string)(results[1]));
            return ((System.Xml.XmlElement)(results[0]));
        }
        
        /// <remarks/>
        public void WS004_EPISODIO_POR_NEPISAsync(WS004_EPISODIO_POR_NEPISInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, string P_QUIENERESVARCHAR2IN, double P_NEPISNUMBERIN, WS004_EPISODIO_POR_NEPISInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT) {
            this.WS004_EPISODIO_POR_NEPISAsync(P_RESULTADOXMLTYPEOUT, P_QUIENERESVARCHAR2IN, P_NEPISNUMBERIN, P_CAMPOSVARCHAR2OUT, null);
        }
        
        /// <remarks/>
        public void WS004_EPISODIO_POR_NEPISAsync(WS004_EPISODIO_POR_NEPISInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, string P_QUIENERESVARCHAR2IN, double P_NEPISNUMBERIN, WS004_EPISODIO_POR_NEPISInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT, object userState) {
            if ((this.WS004_EPISODIO_POR_NEPISOperationCompleted == null)) {
                this.WS004_EPISODIO_POR_NEPISOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWS004_EPISODIO_POR_NEPISOperationCompleted);
            }
            this.InvokeAsync("WS004_EPISODIO_POR_NEPIS", new object[] {
                        P_RESULTADOXMLTYPEOUT,
                        P_QUIENERESVARCHAR2IN,
                        P_NEPISNUMBERIN,
                        P_CAMPOSVARCHAR2OUT}, this.WS004_EPISODIO_POR_NEPISOperationCompleted, userState);
        }
        
        private void OnWS004_EPISODIO_POR_NEPISOperationCompleted(object arg) {
            if ((this.WS004_EPISODIO_POR_NEPISCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WS004_EPISODIO_POR_NEPISCompleted(this, new WS004_EPISODIO_POR_NEPISCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WS003_EPISODIOS_POR_NDNI", RequestElementName="WS003_EPISODIOS_POR_NDNIInput", RequestNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ResponseElementName="WS003_EPISODIOS_POR_NDNIOutput", ResponseNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("P_RESULTADO")]
        public System.Xml.XmlElement WS003_EPISODIOS_POR_NDNI([System.Xml.Serialization.XmlElementAttribute("P_RESULTADO-XMLTYPE-OUT")] WS003_EPISODIOS_POR_NDNIInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, [System.Xml.Serialization.XmlElementAttribute("P_QUIENERES-VARCHAR2-IN")] string P_QUIENERESVARCHAR2IN, [System.Xml.Serialization.XmlElementAttribute("P_NDNI-VARCHAR2-IN")] string P_NDNIVARCHAR2IN, [System.Xml.Serialization.XmlElementAttribute("P_CAMPOS-VARCHAR2-OUT")] WS003_EPISODIOS_POR_NDNIInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT, out string P_CAMPOS) {
            object[] results = this.Invoke("WS003_EPISODIOS_POR_NDNI", new object[] {
                        P_RESULTADOXMLTYPEOUT,
                        P_QUIENERESVARCHAR2IN,
                        P_NDNIVARCHAR2IN,
                        P_CAMPOSVARCHAR2OUT});
            P_CAMPOS = ((string)(results[1]));
            return ((System.Xml.XmlElement)(results[0]));
        }
        
        /// <remarks/>
        public void WS003_EPISODIOS_POR_NDNIAsync(WS003_EPISODIOS_POR_NDNIInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, string P_QUIENERESVARCHAR2IN, string P_NDNIVARCHAR2IN, WS003_EPISODIOS_POR_NDNIInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT) {
            this.WS003_EPISODIOS_POR_NDNIAsync(P_RESULTADOXMLTYPEOUT, P_QUIENERESVARCHAR2IN, P_NDNIVARCHAR2IN, P_CAMPOSVARCHAR2OUT, null);
        }
        
        /// <remarks/>
        public void WS003_EPISODIOS_POR_NDNIAsync(WS003_EPISODIOS_POR_NDNIInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, string P_QUIENERESVARCHAR2IN, string P_NDNIVARCHAR2IN, WS003_EPISODIOS_POR_NDNIInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT, object userState) {
            if ((this.WS003_EPISODIOS_POR_NDNIOperationCompleted == null)) {
                this.WS003_EPISODIOS_POR_NDNIOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWS003_EPISODIOS_POR_NDNIOperationCompleted);
            }
            this.InvokeAsync("WS003_EPISODIOS_POR_NDNI", new object[] {
                        P_RESULTADOXMLTYPEOUT,
                        P_QUIENERESVARCHAR2IN,
                        P_NDNIVARCHAR2IN,
                        P_CAMPOSVARCHAR2OUT}, this.WS003_EPISODIOS_POR_NDNIOperationCompleted, userState);
        }
        
        private void OnWS003_EPISODIOS_POR_NDNIOperationCompleted(object arg) {
            if ((this.WS003_EPISODIOS_POR_NDNICompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WS003_EPISODIOS_POR_NDNICompleted(this, new WS003_EPISODIOS_POR_NDNICompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WS002_EPISODIOS_POR_NHIST", RequestElementName="WS002_EPISODIOS_POR_NHISTInput", RequestNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ResponseElementName="WS002_EPISODIOS_POR_NHISTOutput", ResponseNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("P_RESULTADO")]
        public System.Xml.XmlElement WS002_EPISODIOS_POR_NHIST([System.Xml.Serialization.XmlElementAttribute("P_RESULTADO-XMLTYPE-OUT")] WS002_EPISODIOS_POR_NHISTInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, [System.Xml.Serialization.XmlElementAttribute("P_QUIENERES-VARCHAR2-IN")] string P_QUIENERESVARCHAR2IN, [System.Xml.Serialization.XmlElementAttribute("P_NHIST-VARCHAR2-IN")] string P_NHISTVARCHAR2IN, [System.Xml.Serialization.XmlElementAttribute("P_CAMPOS-VARCHAR2-OUT")] WS002_EPISODIOS_POR_NHISTInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT, out string P_CAMPOS) {
            object[] results = this.Invoke("WS002_EPISODIOS_POR_NHIST", new object[] {
                        P_RESULTADOXMLTYPEOUT,
                        P_QUIENERESVARCHAR2IN,
                        P_NHISTVARCHAR2IN,
                        P_CAMPOSVARCHAR2OUT});
            P_CAMPOS = ((string)(results[1]));
            return ((System.Xml.XmlElement)(results[0]));
        }
        
        /// <remarks/>
        public void WS002_EPISODIOS_POR_NHISTAsync(WS002_EPISODIOS_POR_NHISTInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, string P_QUIENERESVARCHAR2IN, string P_NHISTVARCHAR2IN, WS002_EPISODIOS_POR_NHISTInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT) {
            this.WS002_EPISODIOS_POR_NHISTAsync(P_RESULTADOXMLTYPEOUT, P_QUIENERESVARCHAR2IN, P_NHISTVARCHAR2IN, P_CAMPOSVARCHAR2OUT, null);
        }
        
        /// <remarks/>
        public void WS002_EPISODIOS_POR_NHISTAsync(WS002_EPISODIOS_POR_NHISTInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, string P_QUIENERESVARCHAR2IN, string P_NHISTVARCHAR2IN, WS002_EPISODIOS_POR_NHISTInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT, object userState) {
            if ((this.WS002_EPISODIOS_POR_NHISTOperationCompleted == null)) {
                this.WS002_EPISODIOS_POR_NHISTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWS002_EPISODIOS_POR_NHISTOperationCompleted);
            }
            this.InvokeAsync("WS002_EPISODIOS_POR_NHIST", new object[] {
                        P_RESULTADOXMLTYPEOUT,
                        P_QUIENERESVARCHAR2IN,
                        P_NHISTVARCHAR2IN,
                        P_CAMPOSVARCHAR2OUT}, this.WS002_EPISODIOS_POR_NHISTOperationCompleted, userState);
        }
        
        private void OnWS002_EPISODIOS_POR_NHISTOperationCompleted(object arg) {
            if ((this.WS002_EPISODIOS_POR_NHISTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WS002_EPISODIOS_POR_NHISTCompleted(this, new WS002_EPISODIOS_POR_NHISTCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WS001_EPISODIOS_POR_NUHSA", RequestElementName="WS001_EPISODIOS_POR_NUHSAInput", RequestNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ResponseElementName="WS001_EPISODIOS_POR_NUHSAOutput", ResponseNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("P_RESULTADO")]
        public System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA([System.Xml.Serialization.XmlElementAttribute("P_RESULTADO-XMLTYPE-OUT")] WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, [System.Xml.Serialization.XmlElementAttribute("P_QUIENERES-VARCHAR2-IN")] string P_QUIENERESVARCHAR2IN, [System.Xml.Serialization.XmlElementAttribute("P_NUHSA-VARCHAR2-IN")] string P_NUHSAVARCHAR2IN, [System.Xml.Serialization.XmlElementAttribute("P_CAMPOS-VARCHAR2-OUT")] WS001_EPISODIOS_POR_NUHSAInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT, out string P_CAMPOS) {
            object[] results = this.Invoke("WS001_EPISODIOS_POR_NUHSA", new object[] {
                        P_RESULTADOXMLTYPEOUT,
                        P_QUIENERESVARCHAR2IN,
                        P_NUHSAVARCHAR2IN,
                        P_CAMPOSVARCHAR2OUT});
            P_CAMPOS = ((string)(results[1]));
            return ((System.Xml.XmlElement)(results[0]));
        }
        
        /// <remarks/>
        public void WS001_EPISODIOS_POR_NUHSAAsync(WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, string P_QUIENERESVARCHAR2IN, string P_NUHSAVARCHAR2IN, WS001_EPISODIOS_POR_NUHSAInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT) {
            this.WS001_EPISODIOS_POR_NUHSAAsync(P_RESULTADOXMLTYPEOUT, P_QUIENERESVARCHAR2IN, P_NUHSAVARCHAR2IN, P_CAMPOSVARCHAR2OUT, null);
        }
        
        /// <remarks/>
        public void WS001_EPISODIOS_POR_NUHSAAsync(WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT P_RESULTADOXMLTYPEOUT, string P_QUIENERESVARCHAR2IN, string P_NUHSAVARCHAR2IN, WS001_EPISODIOS_POR_NUHSAInputP_CAMPOSVARCHAR2OUT P_CAMPOSVARCHAR2OUT, object userState) {
            if ((this.WS001_EPISODIOS_POR_NUHSAOperationCompleted == null)) {
                this.WS001_EPISODIOS_POR_NUHSAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWS001_EPISODIOS_POR_NUHSAOperationCompleted);
            }
            this.InvokeAsync("WS001_EPISODIOS_POR_NUHSA", new object[] {
                        P_RESULTADOXMLTYPEOUT,
                        P_QUIENERESVARCHAR2IN,
                        P_NUHSAVARCHAR2IN,
                        P_CAMPOSVARCHAR2OUT}, this.WS001_EPISODIOS_POR_NUHSAOperationCompleted, userState);
        }
        
        private void OnWS001_EPISODIOS_POR_NUHSAOperationCompleted(object arg) {
            if ((this.WS001_EPISODIOS_POR_NUHSACompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WS001_EPISODIOS_POR_NUHSACompleted(this, new WS001_EPISODIOS_POR_NUHSACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WRITE_LOPD", RequestElementName="WRITE_LOPDInput", RequestNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ResponseElementName="WRITE_LOPDOutput", ResponseNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void WRITE_LOPD([System.Xml.Serialization.XmlElementAttribute("P_RESULTADO-XMLTYPE-IN")] System.Xml.XmlElement P_RESULTADOXMLTYPEIN, [System.Xml.Serialization.XmlElementAttribute("P_QUIENERES-VARCHAR2-IN")] string P_QUIENERESVARCHAR2IN, [System.Xml.Serialization.XmlElementAttribute("P_INPUT-VARCHAR2-IN")] string P_INPUTVARCHAR2IN) {
            this.Invoke("WRITE_LOPD", new object[] {
                        P_RESULTADOXMLTYPEIN,
                        P_QUIENERESVARCHAR2IN,
                        P_INPUTVARCHAR2IN});
        }
        
        /// <remarks/>
        public void WRITE_LOPDAsync(System.Xml.XmlElement P_RESULTADOXMLTYPEIN, string P_QUIENERESVARCHAR2IN, string P_INPUTVARCHAR2IN) {
            this.WRITE_LOPDAsync(P_RESULTADOXMLTYPEIN, P_QUIENERESVARCHAR2IN, P_INPUTVARCHAR2IN, null);
        }
        
        /// <remarks/>
        public void WRITE_LOPDAsync(System.Xml.XmlElement P_RESULTADOXMLTYPEIN, string P_QUIENERESVARCHAR2IN, string P_INPUTVARCHAR2IN, object userState) {
            if ((this.WRITE_LOPDOperationCompleted == null)) {
                this.WRITE_LOPDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWRITE_LOPDOperationCompleted);
            }
            this.InvokeAsync("WRITE_LOPD", new object[] {
                        P_RESULTADOXMLTYPEIN,
                        P_QUIENERESVARCHAR2IN,
                        P_INPUTVARCHAR2IN}, this.WRITE_LOPDOperationCompleted, userState);
        }
        
        private void OnWRITE_LOPDOperationCompleted(object arg) {
            if ((this.WRITE_LOPDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WRITE_LOPDCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("START_UP", RequestElementName="START_UPInput", RequestNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ResponseElementName="START_UPOutput", ResponseNamespace="http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void START_UP([System.Xml.Serialization.XmlElementAttribute("P_QUIENERES-VARCHAR2-IN")] string P_QUIENERESVARCHAR2IN) {
            this.Invoke("START_UP", new object[] {
                        P_QUIENERESVARCHAR2IN});
        }
        
        /// <remarks/>
        public void START_UPAsync(string P_QUIENERESVARCHAR2IN) {
            this.START_UPAsync(P_QUIENERESVARCHAR2IN, null);
        }
        
        /// <remarks/>
        public void START_UPAsync(string P_QUIENERESVARCHAR2IN, object userState) {
            if ((this.START_UPOperationCompleted == null)) {
                this.START_UPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSTART_UPOperationCompleted);
            }
            this.InvokeAsync("START_UP", new object[] {
                        P_QUIENERESVARCHAR2IN}, this.START_UPOperationCompleted, userState);
        }
        
        private void OnSTART_UPOperationCompleted(object arg) {
            if ((this.START_UPCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.START_UPCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class WS005_EPISODIO_POR_NADMIInputP_RESULTADOXMLTYPEOUT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class WS005_EPISODIO_POR_NADMIInputP_CAMPOSVARCHAR2OUT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class WS004_EPISODIO_POR_NEPISInputP_RESULTADOXMLTYPEOUT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class WS004_EPISODIO_POR_NEPISInputP_CAMPOSVARCHAR2OUT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class WS003_EPISODIOS_POR_NDNIInputP_RESULTADOXMLTYPEOUT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class WS003_EPISODIOS_POR_NDNIInputP_CAMPOSVARCHAR2OUT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class WS002_EPISODIOS_POR_NHISTInputP_RESULTADOXMLTYPEOUT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class WS002_EPISODIOS_POR_NHISTInputP_CAMPOSVARCHAR2OUT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class WS001_EPISODIOS_POR_NUHSAInputP_CAMPOSVARCHAR2OUT {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void WS005_EPISODIO_POR_NADMICompletedEventHandler(object sender, WS005_EPISODIO_POR_NADMICompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WS005_EPISODIO_POR_NADMICompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WS005_EPISODIO_POR_NADMICompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlElement Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlElement)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string P_CAMPOS {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void WS004_EPISODIO_POR_NEPISCompletedEventHandler(object sender, WS004_EPISODIO_POR_NEPISCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WS004_EPISODIO_POR_NEPISCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WS004_EPISODIO_POR_NEPISCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlElement Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlElement)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string P_CAMPOS {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void WS003_EPISODIOS_POR_NDNICompletedEventHandler(object sender, WS003_EPISODIOS_POR_NDNICompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WS003_EPISODIOS_POR_NDNICompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WS003_EPISODIOS_POR_NDNICompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlElement Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlElement)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string P_CAMPOS {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void WS002_EPISODIOS_POR_NHISTCompletedEventHandler(object sender, WS002_EPISODIOS_POR_NHISTCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WS002_EPISODIOS_POR_NHISTCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WS002_EPISODIOS_POR_NHISTCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlElement Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlElement)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string P_CAMPOS {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void WS001_EPISODIOS_POR_NUHSACompletedEventHandler(object sender, WS001_EPISODIOS_POR_NUHSACompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WS001_EPISODIOS_POR_NUHSACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WS001_EPISODIOS_POR_NUHSACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlElement Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlElement)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string P_CAMPOS {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void WRITE_LOPDCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void START_UPCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591