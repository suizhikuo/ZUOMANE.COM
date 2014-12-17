using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
//using System.ServiceModel.DomainServices.Hosting;
//using System.ServiceModel.DomainServices.Server;

namespace COM.ZUOMANE.Models
{
	// The MetadataTypeAttribute identifies TbDealerInfoManageMetadata as the class
	// that carries additional metadata for the TbDealerInfoManage class.
	[MetadataTypeAttribute(typeof(Test.TestMetadata))]
	public partial class Test
	{
		// This class allows you to attach custom attributes to properties
		// of the TbDealerInfoManage class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class TestMetadata
		{
			// Metadata classes are not meant to be instantiated.
			private TestMetadata()
			{ }

			[Display(Name = "显示名称")]
			public int ID { get; set; }

			[Display(Name = "显示名称")]
			public string UserName { get; set; }

			[Display(Name = "显示名称")]
			public string Password { get; set; }
		}
	}
}
