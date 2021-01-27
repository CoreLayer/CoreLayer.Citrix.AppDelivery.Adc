using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns.NsLicense;
using System.Collections;
using System.Collections.Generic;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.Ns
{
    public class NsLicenseResponseDataTestEnumerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsLicenseResponseData()
                {
                    WebLogging = false,
                    SurgeProtection = false,
                    LoadBalancing = false,
                    ContentSwitching = false,
                    CacheRedirection = false,
                    SureConnect = false,
                    CompressionControl = false,
                    DeltaCompression = false,
                    PriorityQueueing = false,
                    SslOffloading = false,
                    GlobalServerLoadBalancing = false,
                    GlobalServerLoadBalancingProximity = false,
                    HttpDenialOfServiceProtection = false,
                    DynamicRouting = false,
                    ContentFiltering = false,
                    ContentAccelerator = false,
                    IntegratedCaching = false,
                    SslVpn = false,
                    LicensedUsers = "5",
                    LicensedIcaUsers = "0",
                    Aaa = false,
                    OspfRouting = false,
                    RipRouting = false,
                    BgpRouting = false,
                    Rewrite = false,
                    Ipv6ProtocolTranslation = false,
                    ApplicationFirewall = false,
                    Responder = false,
                    AccessGateway = false,
                    NsxNode = false,
                    HtmlInjection = false,
                    ModelId = "20",
                    CitrixAdcPush = false,
                    WebInterfaceOnNetScaler = false,
                    AppFlow = false,
                    CloudBridge = false,
                    CloudBridgeAppliance = false,
                    CloudExtenderAppliance = false,
                    IsisRouting = false,
                    Cluster = false,
                    CallHome = false,
                    AppQoE = false,
                    AppFlowIca = false,
                    IsStandardEditionLicense = false,
                    IsAdvancedEditionLicense = false,
                    IsPremiumLicense = false,
                    IsSimpleGatewayLicense = false,
                    IsSecureWebGatewayLicense = false,
                    FrontEndOptimization = false,
                    LargeScaleNat = false,
                    LicensingMode = "EXPRESS",
                    DaysToExpiration = "0",
                    RdpProxy = false,
                    Reputation = false,
                    UrlFiltering = false,
                    VideoOptimization = false,
                    ForwardProxy = false,
                    SslInterception = false,
                    RemoteContentInspection = false,
                    AdaptiveTcp = false,
                    ConnectionQualityAnalytics = false,
                    BotManagement = false,
                    ApiGateway = false
                },
                new Dictionary<string, string>
                {
                    {
                        "ContentString",
                        "{\"wl\":false,\"sp\":false,\"lb\":false,\"cs\":false,\"cr\":false,\"sc\":false,\"cmp\":false,\"delta\":false,\"pq\":false,\"ssl\":false,\"gslb\":false,\"gslbp\":false,\"hdosp\":false,\"routing\":false,\"cf\":false,\"contentaccelerator\":false,\"ic\":false,\"sslvpn\":false,\"f_sslvpn_users\":\"5\",\"f_ica_users\":\"0\",\"aaa\":false,\"ospf\":false,\"rip\":false,\"bgp\":false,\"rewrite\":false,\"ipv6pt\":false,\"appfw\":false,\"responder\":false,\"agee\":false,\"nsxn\":false,\"htmlinjection\":false,\"modelid\":\"20\",\"push\":false,\"wionns\":false,\"appflow\":false,\"cloudbridge\":false,\"cloudbridgeappliance\":false,\"cloudextenderappliance\":false,\"isis\":false,\"cluster\":false,\"ch\":false,\"appqoe\":false,\"appflowica\":false,\"isstandardlic\":false,\"isenterpriselic\":false,\"isplatinumlic\":false,\"issgwylic\":false,\"isswglic\":false,\"feo\":false,\"lsn\":false,\"licensingmode\":\"EXPRESS\",\"daystoexpiration\":\"0\",\"rdpproxy\":false,\"rep\":false,\"urlfiltering\":false,\"videooptimization\":false,\"forwardproxy\":false,\"sslinterception\":false,\"remotecontentinspection\":false,\"adaptivetcp\":false,\"cqa\":false,\"bot\":false,\"apigateway\":false}"
                    }
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
