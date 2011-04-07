using RestSharp;

namespace Stormbreaker.Dropbox.Helpers {
    public class RequestHelper : IRequestHelper {
        private const string Version = "0";
        /// <summary>
        /// Creates the metadata request.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public RestRequest CreateMetadataRequest(string path) {
            var request = new RestRequest(Method.GET) {Resource = "{version}/metadata/dropbox{path}"};
            request.AddParameter("version", Version, ParameterType.UrlSegment);
            request.AddParameter("path", path, ParameterType.UrlSegment);

            return request;
        }
        /// <summary>
        /// Creates the get file request.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public RestRequest CreateGetFileRequest(string path) {
            var request = new RestRequest(Method.GET) {Resource = "{version}/files/dropbox{path}"};
            request.AddParameter("version", Version, ParameterType.UrlSegment);
            request.AddParameter("path", path, ParameterType.UrlSegment);

            return request;
        }
        /// <summary>
        /// Creates the login request.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public RestRequest CreateLoginRequest(string apiKey, string email, string password) {
            var request = new RestRequest(Method.GET) {Resource = "{version}/token"};
            request.AddParameter("version", Version, ParameterType.UrlSegment);
            request.AddParameter("oauth_consumer_key", apiKey);
            request.AddParameter("email", email);
            request.AddParameter("password", password);
            return request;
        }
        #region old
        //public RestRequest CreateUploadFileRequest(string path, string filename, byte[] fileData) {
        //    var request = new RestRequest(Method.POST);
        //    request.Resource = "{version}/files/dropbox{path}";
        //    request.AddParameter("version", _version, ParameterType.UrlSegment);
        //    request.AddParameter("path", path, ParameterType.UrlSegment);
        //    //Need to add the "file" parameter with the file name
        //    request.AddParameter("file", filename);

        //    request.AddFile("file",fileData, filename);

        //    return request;
        //}

        //public RestRequest CreateDeleteFileRequest(string path) {
        //    var request = new RestRequest(Method.GET);
        //    request.Resource = "{version}/fileops/delete";
        //    request.AddParameter("version", _version, ParameterType.UrlSegment);

        //    request.AddParameter("path", path);
        //    request.AddParameter("root", "dropbox");

        //    return request;
        //}

        //public RestRequest CreateCopyFileRequest(string fromPath, string toPath) {
        //    var request = new RestRequest(Method.GET);
        //    request.Resource = "{version}/fileops/copy";
        //    request.AddParameter("version", _version, ParameterType.UrlSegment);

        //    request.AddParameter("from_path", fromPath);
        //    request.AddParameter("to_path", toPath);
        //    request.AddParameter("root", "dropbox");

        //    return request;
        //}

        //public RestRequest CreateMoveFileRequest(string fromPath, string toPath) {
        //    var request = new RestRequest(Method.GET);
        //    request.Resource = "{version}/fileops/move";
        //    request.AddParameter("version", _version, ParameterType.UrlSegment);

        //    request.AddParameter("from_path", fromPath);
        //    request.AddParameter("to_path", toPath);
        //    request.AddParameter("root", "dropbox");

        //    return request;
        //}



        //public RestRequest CreateNewAccountRequest(string apiKey, string email, string firstName, string lastName, string password) {
        //    var request = new RestRequest(Method.POST);
        //    request.Resource = "{version}/account";
        //    request.AddParameter("version", _version, ParameterType.UrlSegment);

        //    request.AddParameter("oauth_consumer_key", apiKey);

        //    request.AddParameter("email", email);
        //    request.AddParameter("first_name", firstName);
        //    request.AddParameter("last_name", lastName);
        //    request.AddParameter("password", password);

        //    return request;
        //}

        //public RestRequest CreateAccountInfoRequest() {
        //    var request = new RestRequest(Method.GET);
        //    request.Resource = "{version}/account/info";
        //    request.AddParameter("version", _version, ParameterType.UrlSegment);

        //    return request;
        //}

        //public RestRequest CreateCreateFolderRequest(string path) {
        //    var request = new RestRequest(Method.GET);
        //    request.Resource = "{version}/fileops/create_folder";
        //    request.AddParameter("version", _version, ParameterType.UrlSegment);

        //    request.AddParameter("path", path);
        //    request.AddParameter("root", "dropbox");

        //    return request;
        //}
        #endregion
    }
}