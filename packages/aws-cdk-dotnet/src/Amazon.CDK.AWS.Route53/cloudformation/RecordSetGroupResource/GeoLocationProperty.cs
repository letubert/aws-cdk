using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Route53.cloudformation.RecordSetGroupResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html </remarks>
    public class GeoLocationProperty : DeputyBase, Amazon.CDK.AWS.Route53.cloudformation.RecordSetGroupResource.IGeoLocationProperty
    {
        /// <summary>``RecordSetGroupResource.GeoLocationProperty.ContinentCode``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordsetgroup-geolocation-continentcode </remarks>
        [JsiiProperty("continentCode", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object ContinentCode
        {
            get;
            set;
        }

        /// <summary>``RecordSetGroupResource.GeoLocationProperty.CountryCode``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-countrycode </remarks>
        [JsiiProperty("countryCode", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object CountryCode
        {
            get;
            set;
        }

        /// <summary>``RecordSetGroupResource.GeoLocationProperty.SubdivisionCode``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-subdivisioncode </remarks>
        [JsiiProperty("subdivisionCode", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object SubdivisionCode
        {
            get;
            set;
        }
    }
}