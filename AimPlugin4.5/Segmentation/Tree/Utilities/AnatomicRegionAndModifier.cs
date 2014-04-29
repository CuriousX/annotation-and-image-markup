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

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 

namespace Segmentation.Tree.Utilities
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class AnatomicCodes
    {

        private AnatomicCodesAnatomicRegion[] anatomicRegionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnatomicRegion")]
        public AnatomicCodesAnatomicRegion[] AnatomicRegion
        {
            get { return this.anatomicRegionField; }
            set { this.anatomicRegionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AnatomicCodesAnatomicRegion
    {

        private AnatomicCodesAnatomicRegionModifier[] modifierField;

        private string codeValueField;

        private string codeMeaningField;

        private string codingSchemeField;

        private string cidField;

        private string contextGroupNameField;

        private string sNOMEDCTConceptIDField;

        private string uMLSConceptUIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modifier")]
        public AnatomicCodesAnatomicRegionModifier[] Modifier
        {
            get { return this.modifierField; }
            set { this.modifierField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeValue
        {
            get { return this.codeValueField; }
            set { this.codeValueField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeMeaning
        {
            get { return this.codeMeaningField; }
            set { this.codeMeaningField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codingScheme
        {
            get { return this.codingSchemeField; }
            set { this.codingSchemeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cid
        {
            get { return this.cidField; }
            set { this.cidField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contextGroupName
        {
            get { return this.contextGroupNameField; }
            set { this.contextGroupNameField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SNOMEDCTConceptID
        {
            get { return this.sNOMEDCTConceptIDField; }
            set { this.sNOMEDCTConceptIDField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UMLSConceptUID
        {
            get { return this.uMLSConceptUIDField; }
            set { this.uMLSConceptUIDField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AnatomicCodesAnatomicRegionModifier
    {

        private string codeValueField;

        private string codeMeaningField;

        private string codingSchemeField;

        private string cidField;

        private string contextGroupNameField;

        private string sNOMEDCTConceptIDField;

        private string uMLSConceptUIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeValue
        {
            get { return this.codeValueField; }
            set { this.codeValueField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeMeaning
        {
            get { return this.codeMeaningField; }
            set { this.codeMeaningField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codingScheme
        {
            get { return this.codingSchemeField; }
            set { this.codingSchemeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cid
        {
            get { return this.cidField; }
            set { this.cidField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contextGroupName
        {
            get { return this.contextGroupNameField; }
            set { this.contextGroupNameField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SNOMEDCTConceptID
        {
            get { return this.sNOMEDCTConceptIDField; }
            set { this.sNOMEDCTConceptIDField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UMLSConceptUID
        {
            get { return this.uMLSConceptUIDField; }
            set { this.uMLSConceptUIDField = value; }
        }
    }
}
