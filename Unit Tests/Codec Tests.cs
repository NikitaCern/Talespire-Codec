using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Talespire_Codec;

namespace Unit_Tests
{
    [TestClass]
    public class Codec_tests
    {
        Codec codec = new Codec();

        [TestMethod]
        public void Decode_Normal()
        {
            string input = "```H4sIAAAAAAAEAFWRIU8DQRCFh2vSIKpqmlNXU3UnmktFZUV/A0HgQPIjEOeaJidxKBQBjVhBgllMCSRY/kENWYXi3u53pF3zMu/Nm9m82f3uPjLLzOzi9vpxs/1ZP3zt377PtvNFx51+vteXr4v182Rzf/e0n8zt+L2MwTLhaml2hSZcDRPejOBz+AJ+llD+qNfo3RzPHM8eT191knih5gqlR+z1bk5Ln1D/aOlv6Y96jl7Al/CdP6AL9c+AHg50/fM8S3uE2iPUnsjn1J3fwbuDWv7pIPmF0oX6X+Rz+FlC9TeDtKdBb9CF/3cYJtQ8I3cjdyN3O8i7z1c+j8/j8/g8Po/Pc6eKfCvyqsizIreKnFrqljpwn4A/cJ/AfQJzlJ/qmG9fl+Rbwy9TnnqOOzh8jjs4/A6/wz8lz4gF+ZfkX5OzkfOInMfcoUCnT/8w+wPbqNAXVAMAAA==```";

            var expectedOutput = "[{\"uuid\":\"ad6c985c-8d8b-44f2-abd5-edc9de568d30\",\"instanceCount\":52,\"instances\":[{\"x\":0,\"y\":0,\"z\":0,\"r\":0},{\"x\":0,\"y\":300,\"z\":0,\"r\":0},{\"x\":0,\"y\":700,\"z\":0,\"r\":0},{\"x\":0,\"y\":900,\"z\":0,\"r\":0},{\"x\":100,\"y\":0,\"z\":0,\"r\":0},{\"x\":100,\"y\":100,\"z\":0,\"r\":0},{\"x\":100,\"y\":200,\"z\":0,\"r\":0},{\"x\":100,\"y\":400,\"z\":0,\"r\":0},{\"x\":100,\"y\":500,\"z\":0,\"r\":0},{\"x\":100,\"y\":600,\"z\":0,\"r\":0},{\"x\":100,\"y\":700,\"z\":0,\"r\":0},{\"x\":100,\"y\":800,\"z\":0,\"r\":0},{\"x\":100,\"y\":900,\"z\":0,\"r\":0},{\"x\":200,\"y\":0,\"z\":0,\"r\":0},{\"x\":200,\"y\":300,\"z\":0,\"r\":0},{\"x\":200,\"y\":700,\"z\":0,\"r\":0},{\"x\":300,\"y\":0,\"z\":0,\"r\":0},{\"x\":300,\"y\":200,\"z\":0,\"r\":0},{\"x\":300,\"y\":300,\"z\":0,\"r\":0},{\"x\":300,\"y\":700,\"z\":0,\"r\":0},{\"x\":300,\"y\":800,\"z\":0,\"r\":0},{\"x\":400,\"y\":0,\"z\":0,\"r\":0},{\"x\":400,\"y\":100,\"z\":0,\"r\":0},{\"x\":400,\"y\":200,\"z\":0,\"r\":0},{\"x\":400,\"y\":300,\"z\":0,\"r\":0},{\"x\":400,\"y\":400,\"z\":0,\"r\":0},{\"x\":400,\"y\":500,\"z\":0,\"r\":0},{\"x\":400,\"y\":700,\"z\":0,\"r\":0},{\"x\":400,\"y\":800,\"z\":0,\"r\":0},{\"x\":500,\"y\":400,\"z\":0,\"r\":0},{\"x\":500,\"y\":600,\"z\":0,\"r\":0},{\"x\":500,\"y\":700,\"z\":0,\"r\":0},{\"x\":500,\"y\":800,\"z\":0,\"r\":0},{\"x\":500,\"y\":900,\"z\":0,\"r\":0},{\"x\":600,\"y\":0,\"z\":0,\"r\":0},{\"x\":600,\"y\":100,\"z\":0,\"r\":0},{\"x\":600,\"y\":200,\"z\":0,\"r\":0},{\"x\":600,\"y\":400,\"z\":0,\"r\":0},{\"x\":600,\"y\":600,\"z\":0,\"r\":0},{\"x\":700,\"y\":200,\"z\":0,\"r\":0},{\"x\":700,\"y\":600,\"z\":0,\"r\":0},{\"x\":700,\"y\":900,\"z\":0,\"r\":0},{\"x\":800,\"y\":0,\"z\":0,\"r\":0},{\"x\":800,\"y\":200,\"z\":0,\"r\":0},{\"x\":800,\"y\":300,\"z\":0,\"r\":0},{\"x\":800,\"y\":400,\"z\":0,\"r\":0},{\"x\":800,\"y\":600,\"z\":0,\"r\":0},{\"x\":800,\"y\":900,\"z\":0,\"r\":0},{\"x\":900,\"y\":100,\"z\":0,\"r\":0},{\"x\":900,\"y\":400,\"z\":0,\"r\":0},{\"x\":900,\"y\":600,\"z\":0,\"r\":0},{\"x\":900,\"y\":700,\"z\":0,\"r\":0}]},{\"uuid\":\"32cfd208-c363-4434-b817-8ba59faeed17\",\"instanceCount\":48,\"instances\":[{\"x\":0,\"y\":100,\"z\":0,\"r\":0},{\"x\":0,\"y\":200,\"z\":0,\"r\":0},{\"x\":0,\"y\":400,\"z\":0,\"r\":0},{\"x\":0,\"y\":500,\"z\":0,\"r\":0},{\"x\":0,\"y\":600,\"z\":0,\"r\":0},{\"x\":0,\"y\":800,\"z\":0,\"r\":0},{\"x\":100,\"y\":300,\"z\":0,\"r\":0},{\"x\":200,\"y\":100,\"z\":0,\"r\":0},{\"x\":200,\"y\":200,\"z\":0,\"r\":0},{\"x\":200,\"y\":400,\"z\":0,\"r\":0},{\"x\":200,\"y\":500,\"z\":0,\"r\":0},{\"x\":200,\"y\":600,\"z\":0,\"r\":0},{\"x\":200,\"y\":800,\"z\":0,\"r\":0},{\"x\":200,\"y\":900,\"z\":0,\"r\":0},{\"x\":300,\"y\":100,\"z\":0,\"r\":0},{\"x\":300,\"y\":400,\"z\":0,\"r\":0},{\"x\":300,\"y\":500,\"z\":0,\"r\":0},{\"x\":300,\"y\":600,\"z\":0,\"r\":0},{\"x\":300,\"y\":900,\"z\":0,\"r\":0},{\"x\":400,\"y\":600,\"z\":0,\"r\":0},{\"x\":400,\"y\":900,\"z\":0,\"r\":0},{\"x\":500,\"y\":0,\"z\":0,\"r\":0},{\"x\":500,\"y\":100,\"z\":0,\"r\":0},{\"x\":500,\"y\":200,\"z\":0,\"r\":0},{\"x\":500,\"y\":300,\"z\":0,\"r\":0},{\"x\":500,\"y\":500,\"z\":0,\"r\":0},{\"x\":600,\"y\":300,\"z\":0,\"r\":0},{\"x\":600,\"y\":500,\"z\":0,\"r\":0},{\"x\":600,\"y\":700,\"z\":0,\"r\":0},{\"x\":600,\"y\":800,\"z\":0,\"r\":0},{\"x\":600,\"y\":900,\"z\":0,\"r\":0},{\"x\":700,\"y\":0,\"z\":0,\"r\":0},{\"x\":700,\"y\":100,\"z\":0,\"r\":0},{\"x\":700,\"y\":300,\"z\":0,\"r\":0},{\"x\":700,\"y\":400,\"z\":0,\"r\":0},{\"x\":700,\"y\":500,\"z\":0,\"r\":0},{\"x\":700,\"y\":700,\"z\":0,\"r\":0},{\"x\":700,\"y\":800,\"z\":0,\"r\":0},{\"x\":800,\"y\":100,\"z\":0,\"r\":0},{\"x\":800,\"y\":500,\"z\":0,\"r\":0},{\"x\":800,\"y\":700,\"z\":0,\"r\":0},{\"x\":800,\"y\":800,\"z\":0,\"r\":0},{\"x\":900,\"y\":0,\"z\":0,\"r\":0},{\"x\":900,\"y\":200,\"z\":0,\"r\":0},{\"x\":900,\"y\":300,\"z\":0,\"r\":0},{\"x\":900,\"y\":500,\"z\":0,\"r\":0},{\"x\":900,\"y\":800,\"z\":0,\"r\":0},{\"x\":900,\"y\":900,\"z\":0,\"r\":0}]}]";

            var output = codec.Decode(input);
            var outputJson = Newtonsoft.Json.JsonConvert.SerializeObject(output).ToString();

            Assert.AreEqual(expectedOutput, outputJson);
        }

        [TestMethod]
        public void Decode_empty()
        {
            string input = "";
            Assert.ThrowsException<ArgumentNullException>(() => codec.Decode(input));
        }

        [TestMethod]
        public void Decode_faulty()
        {
            string input = "`H4sIAAAAAAAEAFWRIU8DQRCFh2vSIKpqmlNXU3UnmktFZUV/A0HgQPIjEOeaJidxKBQBjVhBgllMCSRY/kENWYXi3u53pF3zMu/Nm9m82f3uPjLLzOzi9vpxs/1ZP3zt377PtvNFx51+vteXr4v182Rzf/e0n8zt+L2MwTLhaml2hSZcDRPejOBz+AJ+llD+qNfo3RzPHM8eT191knih5gqlR+z1bk5Ln1D/aOlv6Y96jl7Al/CdP6AL9c+AHg50/fM8S3uE2iPUnsjn1J3fwbuDWv7pIPmF0oX6X+Rz+FlC9TeDtKdBb9CF/3cYJtQ8I3cjdyN3O8i7z1c+j8/j8/g8Po/Pc6eKfCvyqsizIreKnFrqljpwn4A/cJ/AfQJzlJ/qmG9fl+Rbwy9TnnqOOzh8jjs4/A6/wz8lz4gF+ZfkX5OzkfOInMfcoUCnT/8w+wPbqNAXVAMAAA==```";
            Assert.ThrowsException<FormatException>(() => codec.Decode(input));
        }

        [TestMethod]
        public void Encode_Normal()
        {
            string input = "```H4sIAAAAAAAEAFWRIU8DQRCFh2vSIKpqmlNXU3UnmktFZUV/A0HgQPIjEOeaJidxKBQBjVhBgllMCSRY/kENWYXi3u53pF3zMu/Nm9m82f3uPjLLzOzi9vpxs/1ZP3zt377PtvNFx51+vteXr4v182Rzf/e0n8zt+L2MwTLhaml2hSZcDRPejOBz+AJ+llD+qNfo3RzPHM8eT191knih5gqlR+z1bk5Ln1D/aOlv6Y96jl7Al/CdP6AL9c+AHg50/fM8S3uE2iPUnsjn1J3fwbuDWv7pIPmF0oX6X+Rz+FlC9TeDtKdBb9CF/3cYJtQ8I3cjdyN3O8i7z1c+j8/j8/g8Po/Pc6eKfCvyqsizIreKnFrqljpwn4A/cJ/AfQJzlJ/qmG9fl+Rbwy9TnnqOOzh8jjs4/A6/wz8lz4gF+ZfkX5OzkfOInMfcoUCnT/8w+wPbqNAXVAMAAA==```";


            var decoded = codec.Decode(input);
            var output = codec.Encode(decoded);

            Assert.AreEqual(input, output);
        }

    }
}
