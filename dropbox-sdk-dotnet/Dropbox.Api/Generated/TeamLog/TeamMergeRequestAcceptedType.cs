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
    /// <para>The team merge request accepted type object</para>
    /// </summary>
    public class TeamMergeRequestAcceptedType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamMergeRequestAcceptedType> Encoder = new TeamMergeRequestAcceptedTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamMergeRequestAcceptedType> Decoder = new TeamMergeRequestAcceptedTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamMergeRequestAcceptedType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public TeamMergeRequestAcceptedType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamMergeRequestAcceptedType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamMergeRequestAcceptedType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the team merge request accepted type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamMergeRequestAcceptedType" />.</para>
        /// </summary>
        private class TeamMergeRequestAcceptedTypeEncoder : enc.StructEncoder<TeamMergeRequestAcceptedType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamMergeRequestAcceptedType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamMergeRequestAcceptedType" />.</para>
        /// </summary>
        private class TeamMergeRequestAcceptedTypeDecoder : enc.StructDecoder<TeamMergeRequestAcceptedType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamMergeRequestAcceptedType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamMergeRequestAcceptedType Create()
            {
                return new TeamMergeRequestAcceptedType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamMergeRequestAcceptedType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}