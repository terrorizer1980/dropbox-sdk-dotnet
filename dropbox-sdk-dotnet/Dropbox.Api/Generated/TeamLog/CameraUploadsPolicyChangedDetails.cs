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
    /// <para>Changed camera uploads setting for team.</para>
    /// </summary>
    public class CameraUploadsPolicyChangedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<CameraUploadsPolicyChangedDetails> Encoder = new CameraUploadsPolicyChangedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<CameraUploadsPolicyChangedDetails> Decoder = new CameraUploadsPolicyChangedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="CameraUploadsPolicyChangedDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New camera uploads setting.</param>
        /// <param name="previousValue">Previous camera uploads setting.</param>
        public CameraUploadsPolicyChangedDetails(CameraUploadsPolicy newValue,
                                                 CameraUploadsPolicy previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="CameraUploadsPolicyChangedDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public CameraUploadsPolicyChangedDetails()
        {
        }

        /// <summary>
        /// <para>New camera uploads setting.</para>
        /// </summary>
        public CameraUploadsPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous camera uploads setting.</para>
        /// </summary>
        public CameraUploadsPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="CameraUploadsPolicyChangedDetails" />.</para>
        /// </summary>
        private class CameraUploadsPolicyChangedDetailsEncoder : enc.StructEncoder<CameraUploadsPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(CameraUploadsPolicyChangedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.CameraUploadsPolicy.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.CameraUploadsPolicy.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="CameraUploadsPolicyChangedDetails" />.</para>
        /// </summary>
        private class CameraUploadsPolicyChangedDetailsDecoder : enc.StructDecoder<CameraUploadsPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="CameraUploadsPolicyChangedDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override CameraUploadsPolicyChangedDetails Create()
            {
                return new CameraUploadsPolicyChangedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(CameraUploadsPolicyChangedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.CameraUploadsPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.CameraUploadsPolicy.Decoder.Decode(reader);
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