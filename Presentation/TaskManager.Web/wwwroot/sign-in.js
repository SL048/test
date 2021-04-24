var createState = function () {
  return "AbitLongerStatevalueoirj[weqom]gq]rognq]poreihnq]erpoigjsfdighjsdofiughbpaodsug]wieghb]qwergadgasdfwef"
}

var createNonce = function () {
  return "nonceValuejka;lskdjf;lkasdfasdfqwefasdgjk[ewprgjqworejhg9ojhjjhr9h9rjhj9rhj9hrdfog[sdf"
}

var signIn = function () {

  var redirectUri = "https://localhost:5001/Home/SignIn";
  var responseType = "id_token token";
  var scope = "openid";
  var authUrl = 
	"/connect/authorize/callback" +
	"?client_id=client_id_js" +
	"&redirect_uri=" + encodeURIComponent(redirectUri) +
	"&response_type=" + encodeURIComponent(responseType) +
	"&scope=" + encodeURIComponent(scope) +
	"&nonce=" + createNonce() +
	"&state=" + createState();
  var returnUrl = encodeURIComponent(authUrl);
  //console.log(returnUrl);

  window.location.href = "https://localhost:44343/Auth/Login?ReturnUrl=" + returnUrl;
}
