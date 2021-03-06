using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "90dce6538f072f69")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.4")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bilder
		///</summary>
		[ImplementPropertyType("bilder")]
		public IEnumerable<IPublishedContent> Bilder
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("bilder"); }
		}

		///<summary>
		/// Einleitung
		///</summary>
		[ImplementPropertyType("einleitung")]
		public IHtmlString Einleitung
		{
			get { return this.GetPropertyValue<IHtmlString>("einleitung"); }
		}

		///<summary>
		/// Titel
		///</summary>
		[ImplementPropertyType("titel")]
		public string Titel
		{
			get { return this.GetPropertyValue<string>("titel"); }
		}

		///<summary>
		/// Titel 2
		///</summary>
		[ImplementPropertyType("titel2")]
		public string Titel2
		{
			get { return this.GetPropertyValue<string>("titel2"); }
		}
	}

	/// <summary>Spielplan</summary>
	[PublishedContentModel("spielplan")]
	public partial class Spielplan : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "spielplan";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Spielplan(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Spielplan, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Titel
		///</summary>
		[ImplementPropertyType("titel")]
		public string Titel
		{
			get { return this.GetPropertyValue<string>("titel"); }
		}
	}

	/// <summary>Programme</summary>
	[PublishedContentModel("programme")]
	public partial class Programme : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "programme";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Programme(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Programme, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Titel
		///</summary>
		[ImplementPropertyType("titel")]
		public string Titel
		{
			get { return this.GetPropertyValue<string>("titel"); }
		}
	}

	/// <summary>Presse</summary>
	[PublishedContentModel("presse")]
	public partial class Presse : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "presse";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Presse(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Presse, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Titel
		///</summary>
		[ImplementPropertyType("titel")]
		public string Titel
		{
			get { return this.GetPropertyValue<string>("titel"); }
		}
	}

	/// <summary>Zur-Person</summary>
	[PublishedContentModel("zurPerson")]
	public partial class ZurPerson : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "zurPerson";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ZurPerson(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ZurPerson, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bild
		///</summary>
		[ImplementPropertyType("bild")]
		public IPublishedContent Bild
		{
			get { return this.GetPropertyValue<IPublishedContent>("bild"); }
		}

		///<summary>
		/// Galerie
		///</summary>
		[ImplementPropertyType("galerie")]
		public IEnumerable<IPublishedContent> Galerie
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("galerie"); }
		}

		///<summary>
		/// Text
		///</summary>
		[ImplementPropertyType("text")]
		public IHtmlString Text
		{
			get { return this.GetPropertyValue<IHtmlString>("text"); }
		}

		///<summary>
		/// Titel
		///</summary>
		[ImplementPropertyType("titel")]
		public string Titel
		{
			get { return this.GetPropertyValue<string>("titel"); }
		}
	}

	/// <summary>Programm</summary>
	[PublishedContentModel("programm")]
	public partial class Programm : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "programm";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Programm(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Programm, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bilder
		///</summary>
		[ImplementPropertyType("bild")]
		public IEnumerable<IPublishedContent> Bild
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("bild"); }
		}

		///<summary>
		/// Künstler
		///</summary>
		[ImplementPropertyType("kuenstler")]
		public IHtmlString Kuenstler
		{
			get { return this.GetPropertyValue<IHtmlString>("kuenstler"); }
		}

		///<summary>
		/// In liste anzeigen: Wir nur auf der Seite "Programme" aufgelistet, wenn der Haken gesetzt ist.
		///</summary>
		[ImplementPropertyType("showInList")]
		public bool ShowInList
		{
			get { return this.GetPropertyValue<bool>("showInList"); }
		}

		///<summary>
		/// Text: ... welcher neben dem Bild läuft
		///</summary>
		[ImplementPropertyType("text")]
		public IHtmlString Text
		{
			get { return this.GetPropertyValue<IHtmlString>("text"); }
		}

		///<summary>
		/// Text unter Bild: ... welcher über die ganze Breite läuft.
		///</summary>
		[ImplementPropertyType("textUnterBild")]
		public IHtmlString TextUnterBild
		{
			get { return this.GetPropertyValue<IHtmlString>("textUnterBild"); }
		}

		///<summary>
		/// Titel
		///</summary>
		[ImplementPropertyType("titel")]
		public string Titel
		{
			get { return this.GetPropertyValue<string>("titel"); }
		}

		///<summary>
		/// Untertitel
		///</summary>
		[ImplementPropertyType("untertitel")]
		public string Untertitel
		{
			get { return this.GetPropertyValue<string>("untertitel"); }
		}
	}

	/// <summary>Aufführung</summary>
	[PublishedContentModel("auffuehrung")]
	public partial class Auffuehrung : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "auffuehrung";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Auffuehrung(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Auffuehrung, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Datum
		///</summary>
		[ImplementPropertyType("datum")]
		public DateTime Datum
		{
			get { return this.GetPropertyValue<DateTime>("datum"); }
		}

		///<summary>
		/// Angaben
		///</summary>
		[ImplementPropertyType("kurzbeschreibung")]
		public string Kurzbeschreibung
		{
			get { return this.GetPropertyValue<string>("kurzbeschreibung"); }
		}

		///<summary>
		/// Programm
		///</summary>
		[ImplementPropertyType("programm")]
		public IPublishedContent Programm
		{
			get { return this.GetPropertyValue<IPublishedContent>("programm"); }
		}

		///<summary>
		/// Titel: Falls kein Programm verlinkt.
		///</summary>
		[ImplementPropertyType("titel")]
		public string Titel
		{
			get { return this.GetPropertyValue<string>("titel"); }
		}

		///<summary>
		/// Untertitel: Falls kein Programm verlinkt.
		///</summary>
		[ImplementPropertyType("untertitel")]
		public string Untertitel
		{
			get { return this.GetPropertyValue<string>("untertitel"); }
		}
	}

	/// <summary>Pressetext</summary>
	[PublishedContentModel("pressetext")]
	public partial class Pressetext : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pressetext";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Pressetext(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Pressetext, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Text
		///</summary>
		[ImplementPropertyType("text")]
		public IHtmlString Text
		{
			get { return this.GetPropertyValue<IHtmlString>("text"); }
		}

		///<summary>
		/// Titel
		///</summary>
		[ImplementPropertyType("titel")]
		public string Titel
		{
			get { return this.GetPropertyValue<string>("titel"); }
		}

		///<summary>
		/// Untertitel
		///</summary>
		[ImplementPropertyType("untertitel")]
		public string Untertitel
		{
			get { return this.GetPropertyValue<string>("untertitel"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
