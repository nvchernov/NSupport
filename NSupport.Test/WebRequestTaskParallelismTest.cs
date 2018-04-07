﻿namespace NSupport.Test {
    using System.IO;
    using System.Net;
    using Xunit;

    public class WebRequestTaskParallelismTest {
        [Fact]
        public void Test_GetResponseAsync() {
            // Create a request for the URL. 		
            var request = WebRequest.Create("https://www.google.com");

            request.GetResponseAsync()
                        .ContinueWith(t => {
                            using (var stream = t.Result.GetResponseStream())
                            using (var reader = new StreamReader(stream)) {
                                var responseFromServer = reader.ReadToEnd();
                                Assert.NotNull(responseFromServer);
                                Assert.NotEqual("", responseFromServer);
                            }
                        })
                        .Wait();
        }

        [Fact]
        public void Test_GetRequestStreamAsync() {
            // Create a request for the URL. 		
            var request = WebRequest.Create("https://www.google.com");
            request.Method = "GET";
            request.GetRequestStreamAsync()
                        .ContinueWith(t => {
                            Assert.NotNull(t.Result);
                        })
                        .Wait();
        }
    }
}
