*{
    margin: 0;
    padding: 0;
}

html{
    height: 100%;
    width: 100%;
}

body{
    height: auto;
    width: 100vw;
    background: linear-gradient(135deg, rgb(0, 255, 102) 20.5%, rgb(63, 220, 255) 86.8%);
}
header {
    background: linear-gradient(135deg, rgb(51, 50, 48) 10.5%, rgb(0, 0, 0) 86.8%);
    box-shadow: rgba(0, 0, 0, 0.56) 0px 0px 20px 10px;
    color: #fff; 
    padding: 5px;
    text-align: center;
    font-family: alkatra;
    text-shadow: 2px 2px 4px #000;
  }
  
  .heading {
    margin: 0;
    font-size: 36px;
  }
  
  .container {
    display: flex;
    flex-direction: column;
    align-items: center;
    background: linear-gradient(135deg, rgb(51, 50, 48) 10.5%, rgb(0, 0, 0) 86.8%);
    box-shadow: rgba(0, 0, 0, 0.56) 0px 22px 70px 4px;
    width: 400px;
    height: auto;
    border-radius: 3px;
    padding: 1rem;
    justify-content: center;
    margin-left: auto;
    margin-right: auto;
  }
  
  .container1 {
    margin-bottom: 20px;
  }
  
  p {
    margin: 0;
    font-size: large;
    color: #fff;
    text-shadow: 2px 2px 4px #000;
    font-family: sans-serif;
  }
  
  input[type="text"] {
    margin-top: 10px;
    padding: 10px; 
    font-size: 16px;
    border: none; 
    border-radius: 4px;
    font-family: sans-serif;
    box-shadow: 0 2px 2px rgba(0, 0, 0, 0.1);
  }
  
  button {
    padding: 10px 20px;
    font-size: 16px;
    margin-top: 2%;
    font-family: sans-serif;
    background-color: #23d22c;
    color: #fff;
    text-shadow: 2px 2px 4px #000;
    border: none;
    border-radius: 3px;
    box-shadow: 0 2px 2px rgba(0, 0, 0, 0.1); 
    cursor: pointer; 
  }
  
  button:hover {
    background-color: #4fda61;
  }
  
  .container #result{
    margin-top: 2rem;
    color: #fff;
    font-family: 'Quicksand', sans-serif;
    text-shadow: 2px 2px 4px #000;
    font-size: large;
    line-height: 2rem;
    padding: 2rem;
  }

  .footer{
    font-size: large;
    font-family: Alkatra;
    margin-top:  20px;
    text-align: center;
    justify-content: center;
  }

  /* Mobile devices */
@media only screen and (max-width: 767px) {
  /* CSS rules for mobile devices */
  header {
    font-size: 24px;
  }
  .container{
   margin-top: 5%;
   width: 80%;
   height: auto;
  }
  .container1 {
    display: block;
    margin-right: 0;
    margin-bottom: 10px;
  }
  input[type="text"] {
    width: 100%;
    margin-right: 0;
    margin-bottom: 10px;
  }
  .button {
    display: block;
  }
  button {
    width: 100%;
  }
}

/* Tablet devices */
@media only screen and (min-width: 768px) and (max-width: 991px) {
  /* CSS rules for tablet devices */
  header {
    font-size: 24px;
  }
  .container{
   margin-top: 5%;
   height: auto;
  }
  .container1 {
    display: block;
    margin-right: 0;
    margin-bottom: 10px;
  }
  input[type="text"] {
    width: 100%;
    margin-right: 0;
    margin-bottom: 10px;
  }
  .button {
    display: block;
  }
  button {
    width: 100%;
  }
}

/* Desktop devices */
@media only screen and (min-width: 992px) {
  /* CSS rules for desktop devices */
  header {
    font-size: 24px;
  }
  .container{
   margin-top: 5%;
   height: auto;
  }
  .container1 {
    display: block;
    margin-right: 0;
    margin-bottom: 10px;
  }
  input[type="text"] {
    width: 100%;
    margin-right: 0;
    margin-bottom: 10px;
  }
  .button {
    display: block;
  }
  button {
    width: 100%;
  }
}
