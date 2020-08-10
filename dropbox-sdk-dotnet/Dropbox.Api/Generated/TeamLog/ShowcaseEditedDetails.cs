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
    /// <para>Edited showcase.</para>
    /// </summary>
    public class ShowcaseEditedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ShowcaseEditedDetails> Encoder = new ShowcaseEditedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ShowcaseEditedDetails> Decoder = new ShowcaseEditedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShowcaseEditedDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="eventUuid">Event unique identifier.</param>
        public ShowcaseEditedDetails(string eventUuid)
        {
            if (eventUuid == null)
            {
                throw new sys.ArgumentNullException("eventUuid");
            }

            this.EventUuid = eventUuid;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShowcaseEditedDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ShowcaseEditedDetails()
        {
        }

        /// <summary>
        /// <para>Event unique identifier.</para>
        /// </summary>
        public string EventUuid { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ShowcaseEditedDetails" />.</para>
        /// </summary>
        private class ShowcaseEditedDetailsEncoder : enc.StructEncoder<ShowcaseEditedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ShowcaseEditedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("event_uuid", value.EventUuid, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ShowcaseEditedDetails" />.</para>
        /// </summary>
        private class ShowcaseEditedDetailsDecoder : enc.StructDecoder<ShowcaseEditedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ShowcaseEditedDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ShowcaseEditedDetails Create()
            {
                return new ShowcaseEditedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ShowcaseEditedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "event_uuid":
                        value.EventUuid = enc.StringDecoder.Instance.Decode(reader);
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