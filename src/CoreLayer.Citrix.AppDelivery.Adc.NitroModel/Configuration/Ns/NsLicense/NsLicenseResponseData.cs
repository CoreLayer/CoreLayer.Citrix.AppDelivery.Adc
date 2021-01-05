using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns.NsLicense
{
    /// <summary>
    /// TODO NsLicenseResponseData
    /// </summary>
    public class NsLicenseResponseData
    {
        [JsonPropertyName("wl")]
        public bool WebLogging { get; set; }
        [JsonPropertyName("sp")]
        public bool SurgeProtection { get; set; }
        [JsonPropertyName("lb")]
        public bool LoadBalancing { get; set; }
        [JsonPropertyName("cs")]
        public bool ContentSwitching { get; set; }
        [JsonPropertyName("cr")]
        public bool CacheRedirection { get; set; }
        [JsonPropertyName("sc")]
        public bool SureConnect { get; set; }
        [JsonPropertyName("cmp")]
        public bool CompressionControl { get; set; }
        [JsonPropertyName("delta")]
        public bool DeltaCompression { get; set; }
        [JsonPropertyName("pq")]
        public bool PriorityQueueing { get; set; }
        [JsonPropertyName("ssl")]
        public bool SslOffloading { get; set; }
        [JsonPropertyName("gslb")]
        public bool GlobalServerLoadBalancing { get; set; }
        [JsonPropertyName("gslbp")]
        public bool GlobalServerLoadBalancingProximity { get; set; }
        [JsonPropertyName("hdosp")]
        public bool HttpDenialOfServiceProtection { get; set; }
        [JsonPropertyName("routing")]
        public bool DynamicRouting { get; set; }
        [JsonPropertyName("cf")]
        public bool ContentFiltering { get; set; }
        [JsonPropertyName("contentaccelerator")]
        public bool ContentAccelerator { get; set; }
        [JsonPropertyName("ic")]
        public bool IntegratedCaching { get; set; }
        [JsonPropertyName("sslvpn")]
        public bool SslVpn { get; set; }
        [JsonPropertyName("f_sslvpn_users")]
        public string LicensedUsers { get; set; }
        [JsonPropertyName("f_ica_users")]
        public string LicensedIcaUsers { get; set; }
        [JsonPropertyName("aaa")]
        public bool Aaa { get; set; }
        [JsonPropertyName("ospf")]
        public bool OspfRouting { get; set; }
        [JsonPropertyName("rip")]
        public bool RipRouting { get; set; }
        [JsonPropertyName("bgp")]
        public bool BgpRouting { get; set; }
        [JsonPropertyName("rewrite")]
        public bool Rewrite { get; set; }
        [JsonPropertyName("ipv6pt")]
        public bool Ipv6ProtocolTranslation { get; set; }
        [JsonPropertyName("appfw")]
        public bool ApplicationFirewall { get; set; }
        [JsonPropertyName("responder")]
        public bool Responder { get; set; }
        [JsonPropertyName("agee")]
        public bool AccessGateway { get; set; }
        [JsonPropertyName("nsxn")]
        public bool NsxNode { get; set; }
        [JsonPropertyName("htmlinjection")]
        public bool HtmlInjection { get; set; }
        [JsonPropertyName("modelid")]
        public string ModelId { get; set; }
        [JsonPropertyName("push")]
        public bool CitrixAdcPush { get; set; }
        [JsonPropertyName("wionns")]
        public bool WebInterfaceOnNetScaler { get; set; }
        [JsonPropertyName("appflow")]
        public bool AppFlow { get; set; }
        [JsonPropertyName("cloudbridge")]
        public bool CloudBridge { get; set; }
        [JsonPropertyName("cloudbridgeappliance")]
        public bool CloudBridgeAppliance { get; set; }
        [JsonPropertyName("cloudextenderappliance")]
        public bool CloudExtenderAppliance { get; set; }
        [JsonPropertyName("isis")]
        public bool IsisRouting { get; set; }
        [JsonPropertyName("cluster")]
        public bool Cluster { get; set; }
        [JsonPropertyName("ch")]
        public bool CallHome { get; set; }
        [JsonPropertyName("appqoe")]
        public bool AppQoE { get; set; }
        [JsonPropertyName("appflowica")]
        public bool AppFlowIca { get; set; }
        [JsonPropertyName("isstandardlic")]
        public bool IsStandardEditionLicense { get; set; }
        [JsonPropertyName("isenterpriselic")]
        public bool IsAdvancedEditionLicense { get; set; }
        [JsonPropertyName("isplatinumlic")]
        public bool IsPremiumLicense { get; set; }
        [JsonPropertyName("issgwylic")]
        public bool IsSimpleGatewayLicense { get; set; }
        [JsonPropertyName("isswglic")]
        public bool IsSecureWebGatewayLicense { get; set; }
        [JsonPropertyName("feo")]
        public bool FrontEndOptimization { get; set; }
        [JsonPropertyName("lsn")]
        public bool LargeScaleNat { get; set; }
        [JsonPropertyName("licensingmode")]
        public string LicensingMode { get; set; }
        [JsonPropertyName("daystoexpiration")]
        public string DaysToExpiration { get; set; }
        [JsonPropertyName("rdpproxy")]
        public bool RdpProxy { get; set; }
        [JsonPropertyName("rep")]
        public bool Reputation { get; set; }
        [JsonPropertyName("urlfiltering")]
        public bool UrlFiltering { get; set; }
        [JsonPropertyName("videooptimization")]
        public bool VideoOptimization { get; set; }
        [JsonPropertyName("forwardproxy")]
        public bool ForwardProxy { get; set; }
        [JsonPropertyName("sslinterception")]
        public bool SslInterception { get; set; }
        [JsonPropertyName("remotecontentinspection")]
        public bool RemoteContentInspection { get; set; }
        [JsonPropertyName("adaptivetcp")]
        public bool AdaptiveTcp { get; set; }
        [JsonPropertyName("cqa")]
        public bool ConnectionQualityAnalytics { get; set; }
        [JsonPropertyName("bot")]
        public bool BotManagement { get; set; }
        [JsonPropertyName("apigateway")]
        public bool ApiGateway { get; set; }
    }
}