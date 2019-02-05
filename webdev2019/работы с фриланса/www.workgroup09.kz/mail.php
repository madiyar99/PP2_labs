<?php

$name = $_POST['user_name'];
$phone = $_POST['user_phone'];

$name = htmlspecialchars($name);
$phone = htmlspecialchars($phone);

$name = urldecode($name);
$phone = urldecode($phone);

$name = trim($name);
$phone = trim($phone);

mail("madiktur99@mail.ru", "Заявка с сайта", "ФИО:".$name.". Phone: ".$phone ,"From: zayavka99@workgroup09.kz \r\n");

if (mail("madiktur99@mail.ru", "Заявка с сайта", "ФИО:".$name.". Phone: ".$phone ,"From: zayavka99@workgroup09.kz \r\n"))
{ 
    echo "сообщение успешно отправлено"; 
}
else 
{ 
    echo "при отправке сообщения возникли ошибки"; 
}




?>