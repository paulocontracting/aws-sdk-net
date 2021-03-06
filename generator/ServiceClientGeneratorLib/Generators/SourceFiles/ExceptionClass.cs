﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ExceptionClass : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Net;\r\nusing Amazon.Runtime;\r\n\r\nnamespace ");
            
            #line 13 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model\r\n{\r\n    ///<summary>\r\n    /// ");
            
            #line 16 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" exception\r\n    /// </summary>\r\n#if !PCL && !NETSTANDARD\r\n    [Serializable]\r\n#en" +
                    "dif\r\n");
            
            #line 21 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
		
		if(this.Exception.Structure.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t[Obsolete(\"");
            
            #line 25 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Structure.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 26 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

		}

            
            #line default
            #line hidden
            this.Write("    public class ");
            
            #line 29 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 29 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BaseException));
            
            #line default
            #line hidden
            this.Write(" \r\n    {\r\n");
            
            #line 31 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

        if(this.Exception.Structure.IsRetryable)
        {

            
            #line default
            #line hidden
            this.Write("        private RetryableDetails _retryableDetails = new RetryableDetails(");
            
            #line 35 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Structure.Throttling.ToString().ToLower()));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n");
            
            #line 37 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

        }

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Constructs a new ");
            
            #line 41 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(" with the specified error\r\n        /// message.\r\n        /// </summary>\r\n        " +
                    "/// <param name=\"message\">\r\n        /// Describes the error encountered.\r\n      " +
                    "  /// </param>\r\n        public ");
            
            #line 47 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("(string message) \r\n            : base(message) {}\r\n          \r\n        /// <summa" +
                    "ry>\r\n        /// Construct instance of ");
            
            #line 51 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n        /// <param name=\"message\"></param>\r\n        ///" +
                    " <param name=\"innerException\"></param>\r\n        public ");
            
            #line 55 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("(string message, Exception innerException) \r\n            : base(message, innerExc" +
                    "eption) {}\r\n            \r\n        /// <summary>\r\n        /// Construct instance " +
                    "of ");
            
            #line 59 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n        /// <param name=\"innerException\"></param>\r\n    " +
                    "    public ");
            
            #line 62 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("(Exception innerException) \r\n            : base(innerException) {}\r\n            \r" +
                    "\n        /// <summary>\r\n        /// Construct instance of ");
            
            #line 66 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(@"
        /// </summary>
        /// <param name=""message""></param>
        /// <param name=""innerException""></param>
        /// <param name=""errorType""></param>
        /// <param name=""errorCode""></param>
        /// <param name=""requestId""></param>
        /// <param name=""statusCode""></param>
        public ");
            
            #line 74 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(@"(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of ");
            
            #line 78 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(@"
        /// </summary>
        /// <param name=""message""></param>
        /// <param name=""errorType""></param>
        /// <param name=""errorCode""></param>
        /// <param name=""requestId""></param>
        /// <param name=""statusCode""></param>
        public ");
            
            #line 85 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("(string message, ErrorType errorType, string errorCode, string requestId, HttpSta" +
                    "tusCode statusCode) \r\n            : base(message, errorType, errorCode, requestI" +
                    "d, statusCode) {}\r\n\r\n");
            
            #line 88 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
		
		if(this.GenerateComplexException)
		{
			foreach(var member in Exception.Structure.Members)
			{
				if(member.PropertyName.Equals("Message")) continue;

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Gets and sets the ");
            
            #line 96 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" property.\r\n        /// </summary>\r\n");
            
            #line 98 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
		
		if(member.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 102 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 103 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

		}

            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 106 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 106 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n\r\n");
            
            #line 108 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

			}
		}

            
            #line default
            #line hidden
            this.Write("\r\n#if !PCL && !NETSTANDARD\r\n        /// <summary>\r\n        /// Constructs a new i" +
                    "nstance of the ");
            
            #line 115 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write(@" class with serialized data.
        /// </summary>
        /// <param name=""info"">The <see cref=""T:System.Runtime.Serialization.SerializationInfo"" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name=""context"">The <see cref=""T:System.Runtime.Serialization.StreamingContext"" /> that contains contextual information about the source or destination.</param>
        /// <exception cref=""T:System.ArgumentNullException"">The <paramref name=""info"" /> parameter is null. </exception>
        /// <exception cref=""T:System.Runtime.Serialization.SerializationException"">The class name is null or <see cref=""P:System.Exception.HResult"" /> is zero (0). </exception>
        protected ");
            
            #line 121 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Exception.Name));
            
            #line default
            #line hidden
            this.Write("(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serializatio" +
                    "n.StreamingContext context)\r\n            : base(info, context)\r\n        {\r\n");
            
            #line 124 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
		
		if(this.GenerateComplexException)
		{

            
            #line default
            #line hidden
            this.Write("            if (info != null)\r\n            {\r\n");
            
            #line 130 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

			foreach(var member in Exception.Structure.Members)
			{
				if(member.PropertyName.Equals("Message")) continue;

            
            #line default
            #line hidden
            this.Write("                this.");
            
            #line 135 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = info.");
            
            #line 135 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.GetSerializationInfoMethodName()));
            
            #line default
            #line hidden
            this.Write("(\"");
            
            #line 135 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("\");\r\n");
            
            #line 136 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

			}

            
            #line default
            #line hidden
            this.Write("            }\r\n");
            
            #line 140 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

		}

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 145 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
		
		if(this.GenerateComplexException && Exception.Structure.Members.Count > 0)
		{

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Sets the <see cref=\"T:System.Runtime.Serializa" +
                    "tion.SerializationInfo\" /> with information about the exception.\r\n        /// </" +
                    "summary>\r\n        /// <param name=\"info\">The <see cref=\"T:System.Runtime.Seriali" +
                    "zation.SerializationInfo\" /> that holds the serialized object data about the exc" +
                    "eption being thrown.</param>\r\n        /// <param name=\"context\">The <see cref=\"T" +
                    ":System.Runtime.Serialization.StreamingContext\" /> that contains contextual info" +
                    "rmation about the source or destination.</param>\r\n        /// <exception cref=\"T" +
                    ":System.ArgumentNullException\">The <paramref name=\"info\" /> parameter is a null " +
                    "reference (Nothing in Visual Basic). </exception>\r\n#if BCL35\r\n        [System.Se" +
                    "curity.Permissions.SecurityPermission(\r\n            System.Security.Permissions." +
                    "SecurityAction.LinkDemand,\r\n            Flags = System.Security.Permissions.Secu" +
                    "rityPermissionFlag.SerializationFormatter)]\r\n#endif\r\n        [System.Security.Se" +
                    "curityCritical]\r\n        // These FxCop rules are giving false-positives for thi" +
                    "s method\r\n        [System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Se" +
                    "curity\", \"CA2123:OverrideLinkDemandsShouldBeIdenticalToBase\")]\r\n        [System." +
                    "Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Security\", \"CA2134:MethodsMu" +
                    "stOverrideWithConsistentTransparencyFxCopRule\")]\r\n        public override void G" +
                    "etObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime" +
                    ".Serialization.StreamingContext context)\r\n        {\r\n            base.GetObjectD" +
                    "ata(info, context);\r\n            if (info != null)\r\n            {\r\n");
            
            #line 169 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

			foreach(var member in Exception.Structure.Members)
			{
				if(member.PropertyName.Equals("Message")) continue;

            
            #line default
            #line hidden
            this.Write("                info.AddValue(\"");
            
            #line 174 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("\", this.");
            
            #line 174 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 175 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

			}

            
            #line default
            #line hidden
            this.Write("            }\r\n        }\r\n");
            
            #line 180 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

		}

            
            #line default
            #line hidden
            this.Write("#endif\r\n");
            
            #line 184 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

        if(this.Exception.Structure.IsRetryable)
        {

            
            #line default
            #line hidden
            this.Write(@"
        /// <summary>
        /// Flag indicating if the exception is retryable and the associated retry
        /// details. A null value indicates that the exception is not retryable.
        /// </summary>
        public override RetryableDetails Retryable
        {
            get
            {
                return _retryableDetails;
            }
        }
");
            
            #line 200 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

        }

            
            #line default
            #line hidden
            this.Write("\t}\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 205 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ExceptionClass.tt"

    public ExceptionModel Exception { get; set; }

	public bool GenerateComplexException { get; set; }

	public string BaseException { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
