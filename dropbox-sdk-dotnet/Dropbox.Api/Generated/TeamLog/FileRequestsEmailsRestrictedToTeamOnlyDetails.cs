// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Enabled file request emails for team.</para>
    /// </summary>
    public class FileRequestsEmailsRestrictedToTeamOnlyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileRequestsEmailsRestrictedToTeamOnlyDetails> Encoder = new FileRequestsEmailsRestrictedToTeamOnlyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileRequestsEmailsRestrictedToTeamOnlyDetails> Decoder = new FileRequestsEmailsRestrictedToTeamOnlyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="FileRequestsEmailsRestrictedToTeamOnlyDetails" /> class.</para>
        /// </summary>
        public FileRequestsEmailsRestrictedToTeamOnlyDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileRequestsEmailsRestrictedToTeamOnlyDetails"
        /// />.</para>
        /// </summary>
        private class FileRequestsEmailsRestrictedToTeamOnlyDetailsEncoder : enc.StructEncoder<FileRequestsEmailsRestrictedToTeamOnlyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileRequestsEmailsRestrictedToTeamOnlyDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileRequestsEmailsRestrictedToTeamOnlyDetails"
        /// />.</para>
        /// </summary>
        private class FileRequestsEmailsRestrictedToTeamOnlyDetailsDecoder : enc.StructDecoder<FileRequestsEmailsRestrictedToTeamOnlyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="FileRequestsEmailsRestrictedToTeamOnlyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileRequestsEmailsRestrictedToTeamOnlyDetails Create()
            {
                return new FileRequestsEmailsRestrictedToTeamOnlyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileRequestsEmailsRestrictedToTeamOnlyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}