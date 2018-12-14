const sendMessage = () => {
    var emailcount = document.getElementById('email-container').children.length;
    var channel = document.getElementById('channel-title').innerHTML;
    
   if(emailcount != 0)
    {
           var xhr = new XMLHttpRequest();
         xhr.open('POST', 'http://localhost:60024/', true)
         
           xhr.send(channel+"#"+document.getElementById('email-container').children[0].innerHTML)
           alert('email has been sent');
   }else{
           alert('no email found');
   }
 
}



sendMessage();
