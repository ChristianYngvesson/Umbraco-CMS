﻿using System;
using System.Collections.Generic;
using Umbraco.Core.Models;

namespace Umbraco.Core
{
    /// <summary>
    /// Contains the valid selector values.
    /// </summary>
    internal static class DeploySelector
    {
        public const string This = "this";
        public const string ThisAndChildren = "this-and-children";
        public const string ThisAndDescendants = "this-and-descendants";
        public const string ChildrenOfThis = "children";
        public const string DescendantsOfThis = "descendants";
    }

    /// <summary>
    /// Defines well-known entity types.
    /// </summary>
    /// <remarks>Well-known entity types are those that Deploy already knows about,
    /// but entity types are strings and so can be extended beyond what is defined here.</remarks>
    internal static class DeployEntityType
    {
        // guid entity types

        public const string AnyGuid = "any-guid"; // that one is for tests

        public const string Document = "document";
        public const string Media = "media";
        public const string Member = "member";

        public const string DictionaryItem = "dictionary-item";
        public const string Macro = "macro";
        public const string Template = "template";

        public const string DocumentType = "document-type";
        public const string DocumentTypeContainer = "document-type-container";
        public const string MediaType = "media-type";
        public const string MediaTypeContainer = "media-type-container";
        public const string DataType = "data-type";
        public const string DataTypeContainer = "data-type-container";
        public const string MemberType = "member-type";
        public const string MemberGroup = "member-group";

        public const string RelationType = "relation-type";

        // string entity types

        public const string AnyString = "any-string"; // that one is for tests

        public const string MediaFile = "media-file";
        public const string TemplateFile = "template-file";
        public const string Script = "script";
        public const string Stylesheet = "stylesheet";
        public const string PartialView = "partial-view";
        public const string PartialViewMacro = "partial-view-macro";
        public const string Xslt = "xslt";

        public static string FromUmbracoObjectType(UmbracoObjectTypes umbracoObjectType)
        {
            switch (umbracoObjectType)
            {
                case UmbracoObjectTypes.Document:
                    return Document;
                case UmbracoObjectTypes.Media:
                    return Media;
                case UmbracoObjectTypes.Member:
                    return Member;
                case UmbracoObjectTypes.Template:
                    return Template;
                case UmbracoObjectTypes.DocumentType:
                    return DocumentType;
                case UmbracoObjectTypes.DocumentTypeContainer:
                    return DocumentTypeContainer;
                case UmbracoObjectTypes.MediaType:
                    return MediaType;
                case UmbracoObjectTypes.MediaTypeContainer:
                    return MediaTypeContainer;
                case UmbracoObjectTypes.DataType:
                    return DataType;
                case UmbracoObjectTypes.DataTypeContainer:
                    return DataTypeContainer;
                case UmbracoObjectTypes.MemberType:
                    return MemberType;
                case UmbracoObjectTypes.MemberGroup:
                    return MemberGroup;
                case UmbracoObjectTypes.Stylesheet:
                    return Stylesheet;
                case UmbracoObjectTypes.RelationType:
                    return RelationType;
            }
            throw new NotSupportedException(string.Format("UmbracoObjectType \"{0}\" does not have a matching EntityType.", umbracoObjectType));
        }

        public static UmbracoObjectTypes ToUmbracoObjectType(string entityType)
        {
            switch (entityType)
            {
                case Document:
                    return UmbracoObjectTypes.Document;
                case Media:
                    return UmbracoObjectTypes.Media;
                case Member:
                    return UmbracoObjectTypes.Member;
                case Template:
                    return UmbracoObjectTypes.Template;
                case DocumentType:
                    return UmbracoObjectTypes.DocumentType;
                case DocumentTypeContainer:
                    return UmbracoObjectTypes.DocumentTypeContainer;
                case MediaType:
                    return UmbracoObjectTypes.MediaType;
                case MediaTypeContainer:
                    return UmbracoObjectTypes.MediaTypeContainer;
                case DataType:
                    return UmbracoObjectTypes.DataType;
                case DataTypeContainer:
                    return UmbracoObjectTypes.DataTypeContainer;
                case MemberType:
                    return UmbracoObjectTypes.MemberType;
                case MemberGroup:
                    return UmbracoObjectTypes.MemberGroup;
                case Stylesheet:
                    return UmbracoObjectTypes.Stylesheet;
                case RelationType:
                    return UmbracoObjectTypes.RelationType;
            }
            throw new NotSupportedException(
                string.Format("EntityType \"{0}\" does not have a matching UmbracoObjectType.", entityType));
        }
    }


    public static partial class Constants
	{
		/// <summary>
		/// Defines the identifiers for property-type alias conventions that are used within the Umbraco core.
		/// </summary>
		public static class Conventions
		{
		    public static class PublicAccess
		    {
                public const string MemberUsernameRuleType = "MemberUsername";               
                public const string MemberRoleRuleType = "MemberRole";

                [Obsolete("No longer supported, this is here for backwards compatibility only")]
                public const string MemberIdRuleType = "MemberId";
                [Obsolete("No longer supported, this is here for backwards compatibility only")]
                public const string MemberGroupIdRuleType = "MemberGroupId";
		    }

		    public static class Localization
		    {
                /// <summary>
                /// The root id for all top level dictionary items
                /// </summary>
                [Obsolete("There is no dictionary root item id anymore, it is simply null")]
                public const string DictionaryItemRootId = "41c7638d-f529-4bff-853e-59a0c2fb1bde";
		    }

		    public static class DataTypes
		    {
		        public const string ListViewPrefix = "List View - ";
		    }

		    public static class PropertyGroups
		    {
		        public const string ListViewGroupName = "umbContainerView";
		    }

			/// <summary>
			/// Constants for Umbraco Content property aliases.
			/// </summary>
			public static class Content
			{
				/// <summary>
				/// Property alias for the Content's Url (internal) redirect.
				/// </summary>
				public const string InternalRedirectId = "umbracoInternalRedirectId";

				/// <summary>
				/// Property alias for the Content's navigational hide, (not actually used in core code).
				/// </summary>
				public const string NaviHide = "umbracoNaviHide";

				/// <summary>
				/// Property alias for the Content's Url redirect.
				/// </summary>
				public const string Redirect = "umbracoRedirect";

				/// <summary>
				/// Property alias for the Content's Url alias.
				/// </summary>
				public const string UrlAlias = "umbracoUrlAlias";

				/// <summary>
				/// Property alias for the Content's Url name.
				/// </summary>
				public const string UrlName = "umbracoUrlName";
			}

			/// <summary>
			/// Constants for Umbraco Media property aliases.
			/// </summary>
			public static class Media
			{
				/// <summary>
				/// Property alias for the Media's file name.
				/// </summary>
				public const string File = "umbracoFile";

				/// <summary>
				/// Property alias for the Media's width.
				/// </summary>
				public const string Width = "umbracoWidth";

				/// <summary>
				/// Property alias for the Media's height.
				/// </summary>
				public const string Height = "umbracoHeight";

				/// <summary>
				/// Property alias for the Media's file size (in bytes).
				/// </summary>
				public const string Bytes = "umbracoBytes";

				/// <summary>
				/// Property alias for the Media's file extension.
				/// </summary>
				public const string Extension = "umbracoExtension";
			}

			/// <summary>
			/// Defines the alias identifiers for Umbraco media types.
			/// </summary>
			public static class MediaTypes
			{
				/// <summary>
				/// MediaType alias for a file.
				/// </summary>
				public const string File = "File";

				/// <summary>
				/// MediaType alias for a folder.
                /// </summary>
				public const string Folder = "Folder";

				/// <summary>
				/// MediaType alias for an image.
				/// </summary>
				public const string Image = "Image";

                /// <summary>
                /// MediaType alias indicating allowing auto-selection.
                /// </summary>
			    public const string AutoSelect = "umbracoAutoSelect";
			}
            
		    /// <summary>
		    /// Constants for Umbraco Member property aliases.
		    /// </summary>		    
		    public static class Member
		    {
                /// <summary>
                /// if a role starts with __umbracoRole we won't show it as it's an internal role used for public access
                /// </summary>
                public static readonly string InternalRolePrefix = "__umbracoRole";

                public static readonly string UmbracoMemberProviderName = "UmbracoMembershipProvider";

                public static readonly string UmbracoRoleProviderName = "UmbracoRoleProvider";

                /// <summary>
                /// Property alias for a Members Password Question
                /// </summary>
                public const string PasswordQuestion = "umbracoMemberPasswordRetrievalQuestion";

                public const string PasswordQuestionLabel = "Password Question";

                /// <summary>
                /// Property alias for Members Password Answer
                /// </summary>
                public const string PasswordAnswer = "umbracoMemberPasswordRetrievalAnswer";

                public const string PasswordAnswerLabel = "Password Answer";

                /// <summary>
                /// Property alias for the Comments on a Member
                /// </summary>
                public const string Comments = "umbracoMemberComments";

                public const string CommentsLabel = "Comments";

                /// <summary>
                /// Property alias for the Approved boolean of a Member
                /// </summary>
                public const string IsApproved = "umbracoMemberApproved";

                public const string IsApprovedLabel = "Is Approved";

                /// <summary>
                /// Property alias for the Locked out boolean of a Member
                /// </summary>
                public const string IsLockedOut = "umbracoMemberLockedOut";

                public const string IsLockedOutLabel = "Is Locked Out";

                /// <summary>
                /// Property alias for the last date the Member logged in
                /// </summary>
                public const string LastLoginDate = "umbracoMemberLastLogin";

                public const string LastLoginDateLabel = "Last Login Date";

                /// <summary>
                /// Property alias for the last date a Member changed its password
                /// </summary>
                public const string LastPasswordChangeDate = "umbracoMemberLastPasswordChangeDate";

                public const string LastPasswordChangeDateLabel = "Last Password Change Date";

                /// <summary>
                /// Property alias for the last date a Member was locked out
                /// </summary>
                public const string LastLockoutDate = "umbracoMemberLastLockoutDate";

                public const string LastLockoutDateLabel = "Last Lockout Date";

                /// <summary>
                /// Property alias for the number of failed login attemps
                /// </summary>
                public const string FailedPasswordAttempts = "umbracoMemberFailedPasswordAttempts";

                public const string FailedPasswordAttemptsLabel = "Failed Password Attempts";

                /// <summary>
                /// Group name to put the membership properties on
                /// </summary>
                internal const string StandardPropertiesGroupName = "Membership";

		        public static Dictionary<string, PropertyType> GetStandardPropertyTypeStubs()
		        {
		            return new Dictionary<string, PropertyType>
		                {
		                    {
		                        Comments,
		                        new PropertyType(PropertyEditors.TextboxMultipleAlias, DataTypeDatabaseType.Ntext, true, Comments)
		                            {
		                                Name = CommentsLabel
		                            }
		                    },
		                    {
		                        FailedPasswordAttempts,
		                        new PropertyType(PropertyEditors.NoEditAlias, DataTypeDatabaseType.Integer, true, FailedPasswordAttempts)
		                            {
		                                Name = FailedPasswordAttemptsLabel
		                            }
		                    },
		                    {
		                        IsApproved,
		                        new PropertyType(PropertyEditors.TrueFalseAlias, DataTypeDatabaseType.Integer, true, IsApproved)
		                            {
		                                Name = IsApprovedLabel
		                            }
		                    },
		                    {
		                        IsLockedOut,
		                        new PropertyType(PropertyEditors.TrueFalseAlias, DataTypeDatabaseType.Integer, true, IsLockedOut)
		                            {
		                                Name = IsLockedOutLabel
		                            }
		                    },
		                    {
		                        LastLockoutDate,
		                        new PropertyType(PropertyEditors.NoEditAlias, DataTypeDatabaseType.Date, true, LastLockoutDate)
		                            {
		                                Name = LastLockoutDateLabel
		                            }
		                    },
		                    {
		                        LastLoginDate,
		                        new PropertyType(PropertyEditors.NoEditAlias, DataTypeDatabaseType.Date, true, LastLoginDate)
		                            {
		                                Name = LastLoginDateLabel
		                            }
		                    },
		                    {
		                        LastPasswordChangeDate,
		                        new PropertyType(PropertyEditors.NoEditAlias, DataTypeDatabaseType.Date, true, LastPasswordChangeDate)
		                            {
		                                Name = LastPasswordChangeDateLabel
		                            }
		                    },
		                    {
		                        PasswordAnswer,
		                        new PropertyType(PropertyEditors.NoEditAlias, DataTypeDatabaseType.Nvarchar, true, PasswordAnswer)
		                            {
		                                Name = PasswordAnswerLabel
		                            }
		                    },
		                    {
		                        PasswordQuestion,
		                        new PropertyType(PropertyEditors.NoEditAlias, DataTypeDatabaseType.Nvarchar, true, PasswordQuestion)
		                            {
		                                Name = PasswordQuestionLabel
		                            }
		                    }
		                };
		        } 
		    }

			/// <summary>
			/// Defines the alias identifiers for Umbraco member types.
			/// </summary>
			public static class MemberTypes
			{
				/// <summary>
				/// MemberType alias for default member type.
				/// </summary>
				public const string DefaultAlias = "Member";

                public const string SystemDefaultProtectType = "_umbracoSystemDefaultProtectType";

			    public const string AllMembersListId = "all-members";
			}

			/// <summary>
			/// Constants for Umbraco URLs/Querystrings.
			/// </summary>
			public static class Url
			{
				/// <summary>
				/// Querystring parameter name used for Umbraco's alternative template functionality.
				/// </summary>
				public const string AltTemplate = "altTemplate";
			}
            
            /// <summary>
            /// Defines the alias identifiers for built-in Umbraco relation types.
            /// </summary>
            public static class RelationTypes
            {
                /// <summary>
                /// ContentType name for default relation type "Relate Document On Copy".
                /// </summary>
                public const string RelateDocumentOnCopyName = "Relate Document On Copy";
                
                /// <summary>
                /// ContentType alias for default relation type "Relate Document On Copy".
                /// </summary>
                public const string RelateDocumentOnCopyAlias = "relateDocumentOnCopy";

                /// <summary>
                /// ContentType name for default relation type "Relate Parent Document On Delete".
                /// </summary>
                public const string RelateParentDocumentOnDeleteName = "Relate Parent Document On Delete";

                /// <summary>
                /// ContentType alias for default relation type "Relate Parent Document On Delete".
                /// </summary>
                public const string RelateParentDocumentOnDeleteAlias = "relateParentDocumentOnDelete";
            }
		}
	}
}