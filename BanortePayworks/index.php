<?php 
	switch($_GET['action']){
		case 'index':
			if($_POST['x_method']=='enlinea'){
				$x_clientid	= urlencode('19');
				$x_name		= urlencode('user_test');
				$x_password	= urlencode('user01');
				$x_mode		= urlencode('Y');
				$x_transtype    = urldecode('Auth');
			
				$x_merchanname	= urlencode('TiendaPruebas');
				$x_merchantid	= urlencode('19');
				$x_merchantcity	= urlencode('Monterrey');
				$x_responsepath	= urldecode(SITE.'carrito/test.html');
				
				
				$x_cardtype = urlencode('visa');
				$x_number	= urlencode('4111111111111111');
				$x_expires	= str_pad('12/16');
				$x_cvv2val	= urlencode('111');
				$x_cvv2indicator = urlencode('1');
				$x_total	= urlencode('189');
				
				
				$x_orderid	= urlencode('123');
				// $x_cid		= urlencode('111111');
				// $x_customer	= urlencode($_POST['cuentahabiente']);
				// $x_desc1	= urlencode('');

				$fields="ClientId=$x_clientid&Name=$x_name&Password=$x_password&MerchantId=$x_merchantid&MerchantName=$x_merchanname&MerchantCity=$x_merchantcity&Mode=$x_mode&TransType=$x_transtype&ResponsePath=$x_responsepath&OrderId=$x_orderid&CustomerName=$x_customer&Amount=$x_total&Concept=$x_desc1&CardType=$x_cardtype&Card=$x_number&Number=$x_number&Expires=$x_expires&Cvv2Val=$x_cvv2val&Cvv2Indicator=$x_cvv2indicator&Total=$x_total"; 							  	
						 
				  # 
				  # Start CURL session 
				  # 
				  $agent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0)"; 
				  #customer payment
				  $ch=curl_init(); 
				  
				  curl_setopt($ch, CURLOPT_URL, "https://eps.banorte.com/recibo"); 
				  curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, 1); 
				  curl_setopt($ch, CURLOPT_NOPROGRESS, 1); 
				  curl_setopt($ch, CURLOPT_VERBOSE, 1); 
				  curl_setopt($ch, CURLOPT_FOLLOWLOCATION,1); 
				  curl_setopt($ch, CURLOPT_POST, 1); 
				  curl_setopt($ch, CURLOPT_POSTFIELDS, $fields); 
				  curl_setopt($ch, CURLOPT_TIMEOUT, 120); 
				  curl_setopt($ch, CURLOPT_USERAGENT, $agent); 
				  curl_setopt($ch, CURLOPT_REFERER, $ref); 
				  curl_setopt($ch, CURLOPT_RETURNTRANSFER, true); 
				  curl_setopt($ch, CURLOPT_COOKIEJAR, $cookie );
				  curl_setopt($ch, CURLOPT_AUTOREFERER, true );
				  
				  
				  $buffer = curl_exec($ch); 
				  $status = curl_getinfo($ch);
				  curl_close($ch);
				  print_r($status);
			}
			break;
		default:
			break;
?>
<div>
	<form id="formaEjemplo" method="post">
		<fieldset>
			<button type="submit" >Enviar</button>
		</fieldset>
	</form>
</div>