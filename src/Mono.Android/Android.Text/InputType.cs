using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.text']/class[@name='InputType']"
	[global::Android.Runtime.Register ("android/text/InputType", DoNotGenerateAcw=true, ApiSince = 3)]
	public partial class InputType : Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_CLASS_DATETIME']"
		[Register ("TYPE_CLASS_DATETIME")]
		public const int TypeClassDatetime = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_CLASS_NUMBER']"
		[Register ("TYPE_CLASS_NUMBER")]
		public const int TypeClassNumber = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_CLASS_PHONE']"
		[Register ("TYPE_CLASS_PHONE")]
		public const int TypeClassPhone = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_CLASS_TEXT']"
		[Register ("TYPE_CLASS_TEXT")]
		public const int TypeClassText = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_DATETIME_VARIATION_DATE']"
		[Register ("TYPE_DATETIME_VARIATION_DATE")]
		public const int TypeDatetimeVariationDate = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_DATETIME_VARIATION_NORMAL']"
		[Register ("TYPE_DATETIME_VARIATION_NORMAL")]
		public const int TypeDatetimeVariationNormal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_DATETIME_VARIATION_TIME']"
		[Register ("TYPE_DATETIME_VARIATION_TIME")]
		public const int TypeDatetimeVariationTime = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_MASK_CLASS']"
		[Register ("TYPE_MASK_CLASS")]
		public const int TypeMaskClass = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_MASK_FLAGS']"
		[Register ("TYPE_MASK_FLAGS")]
		public const int TypeMaskFlags = (int) 16773120;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_MASK_VARIATION']"
		[Register ("TYPE_MASK_VARIATION")]
		public const int TypeMaskVariation = (int) 4080;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_NULL']"
		[Register ("TYPE_NULL")]
		public const int TypeNull = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_NUMBER_FLAG_DECIMAL']"
		[Register ("TYPE_NUMBER_FLAG_DECIMAL")]
		public const int TypeNumberFlagDecimal = (int) 8192;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_NUMBER_FLAG_SIGNED']"
		[Register ("TYPE_NUMBER_FLAG_SIGNED")]
		public const int TypeNumberFlagSigned = (int) 4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_NUMBER_VARIATION_NORMAL']"
		[Register ("TYPE_NUMBER_VARIATION_NORMAL", ApiSince = 11)]
		public const int TypeNumberVariationNormal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_NUMBER_VARIATION_PASSWORD']"
		[Register ("TYPE_NUMBER_VARIATION_PASSWORD", ApiSince = 11)]
		public const int TypeNumberVariationPassword = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_FLAG_AUTO_COMPLETE']"
		[Register ("TYPE_TEXT_FLAG_AUTO_COMPLETE")]
		public const int TypeTextFlagAutoComplete = (int) 65536;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_FLAG_AUTO_CORRECT']"
		[Register ("TYPE_TEXT_FLAG_AUTO_CORRECT")]
		public const int TypeTextFlagAutoCorrect = (int) 32768;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_FLAG_CAP_CHARACTERS']"
		[Register ("TYPE_TEXT_FLAG_CAP_CHARACTERS")]
		public const int TypeTextFlagCapCharacters = (int) 4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_FLAG_CAP_SENTENCES']"
		[Register ("TYPE_TEXT_FLAG_CAP_SENTENCES")]
		public const int TypeTextFlagCapSentences = (int) 16384;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_FLAG_CAP_WORDS']"
		[Register ("TYPE_TEXT_FLAG_CAP_WORDS")]
		public const int TypeTextFlagCapWords = (int) 8192;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_FLAG_IME_MULTI_LINE']"
		[Register ("TYPE_TEXT_FLAG_IME_MULTI_LINE")]
		public const int TypeTextFlagImeMultiLine = (int) 262144;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_FLAG_MULTI_LINE']"
		[Register ("TYPE_TEXT_FLAG_MULTI_LINE")]
		public const int TypeTextFlagMultiLine = (int) 131072;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_FLAG_NO_SUGGESTIONS']"
		[Register ("TYPE_TEXT_FLAG_NO_SUGGESTIONS", ApiSince = 5)]
		public const int TypeTextFlagNoSuggestions = (int) 524288;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_EMAIL_ADDRESS']"
		[Register ("TYPE_TEXT_VARIATION_EMAIL_ADDRESS")]
		public const int TypeTextVariationEmailAddress = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_EMAIL_SUBJECT']"
		[Register ("TYPE_TEXT_VARIATION_EMAIL_SUBJECT")]
		public const int TypeTextVariationEmailSubject = (int) 48;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_FILTER']"
		[Register ("TYPE_TEXT_VARIATION_FILTER")]
		public const int TypeTextVariationFilter = (int) 176;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_LONG_MESSAGE']"
		[Register ("TYPE_TEXT_VARIATION_LONG_MESSAGE")]
		public const int TypeTextVariationLongMessage = (int) 80;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_NORMAL']"
		[Register ("TYPE_TEXT_VARIATION_NORMAL")]
		public const int TypeTextVariationNormal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_PASSWORD']"
		[Register ("TYPE_TEXT_VARIATION_PASSWORD")]
		public const int TypeTextVariationPassword = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_PERSON_NAME']"
		[Register ("TYPE_TEXT_VARIATION_PERSON_NAME")]
		public const int TypeTextVariationPersonName = (int) 96;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_PHONETIC']"
		[Register ("TYPE_TEXT_VARIATION_PHONETIC")]
		public const int TypeTextVariationPhonetic = (int) 192;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_POSTAL_ADDRESS']"
		[Register ("TYPE_TEXT_VARIATION_POSTAL_ADDRESS")]
		public const int TypeTextVariationPostalAddress = (int) 112;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_SHORT_MESSAGE']"
		[Register ("TYPE_TEXT_VARIATION_SHORT_MESSAGE")]
		public const int TypeTextVariationShortMessage = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_URI']"
		[Register ("TYPE_TEXT_VARIATION_URI")]
		public const int TypeTextVariationUri = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_VISIBLE_PASSWORD']"
		[Register ("TYPE_TEXT_VARIATION_VISIBLE_PASSWORD")]
		public const int TypeTextVariationVisiblePassword = (int) 144;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_WEB_EDIT_TEXT']"
		[Register ("TYPE_TEXT_VARIATION_WEB_EDIT_TEXT")]
		public const int TypeTextVariationWebEditText = (int) 160;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_WEB_EMAIL_ADDRESS']"
		[Register ("TYPE_TEXT_VARIATION_WEB_EMAIL_ADDRESS", ApiSince = 11)]
		public const int TypeTextVariationWebEmailAddress = (int) 208;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.text']/class[@name='InputType']/field[@name='TYPE_TEXT_VARIATION_WEB_PASSWORD']"
		[Register ("TYPE_TEXT_VARIATION_WEB_PASSWORD", ApiSince = 11)]
		public const int TypeTextVariationWebPassword = (int) 224;
		static readonly JniPeerMembers _members = new XAPeerMembers ("android/text/InputType", typeof (InputType));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected InputType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
