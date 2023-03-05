function desabilitar()
{
  var formElem = document.getElementById("formPrincipal");
  for(var i = 0; i < formElem.elements.length; i++)
  {
    formElem.elements[i].disabled = true;
  }
}

function habilitar()
{
    var formElem = document.getElementById("formPrincipal");
    for(var i = 0; i < formElem.elements.length; i++)
    {
        formElem.elements[i].disabled = false;
    }
}

function apagar()
{
  var formElem = document.getElementById("formPrincipal");
  formElem.style.display = "none";
}

var listaP = document.getElementsByTagName("P");
for(var i = 0; i< listaP.length; i++)
{
  listaP[i].style.fontSize = "18px";
  listaP[i].style.fontFamily = "Helvetica, sans-serif";
  listaP[i].style.margin = "20px 10px 20px 10px";
}