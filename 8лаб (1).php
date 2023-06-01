<!DOCTYPE HTML>
<html>
<head>
<meta charset="utf-8">
</head>
<body>
<div id="table-container" style="display: inline-block;"></div>

<div id="pik" style="display: inline-block;"></div>
<br>
<br>
<br>
<div style="width: 50px; background-color: blue; display: inline-block;" id="1"></div>
<div style="width: 50px; background-color:cadetblue;display: inline-block;" id="2"></div>
<div style="width: 50px; background-color:brown;display: inline-block;" id="3"></div>
<div style="width: 50px; background-color:blueviolet;display: inline-block;" id="4"></div>
<br>
<div style="display: inline-block;">Отлич.</div>
<div style="display: inline-block;">Хорош.</div>
<div style="display: inline-block;">Успева.</div>
<div style="display: inline-block;">Неусп.</div>
<script>
var tableHtml = '<table style="Display: table-cell; float:left;">'
let pyk;
mass = new Array;
let arr = ["Путин","Сталин","Ленин","Самадов","Каримов","Иванов","Шабалина","Сторожева","Гладков","Усс"];
for(let i=0;i<10;i++)
{
tableHtml += '<tr >';
mass[i]=[];
for (let j=0;j<3;j++)
{
if(j<2){
mass[i][j] = Math.round(Math.random()*(5-2)+2);
tableHtml += '<td>' + mass[i][j] + '</td>';
}
else {
tableHtml += '<td>' + arr[i] + '</td>';
}
}

tableHtml += '</tr>';
}
tableHtml += '</table>';
document.getElementById('table-container').innerHTML = tableHtml;

let o=0, x=0, y=0,ny=0;
for (i = 0; i<10;i++)
{
if(mass[i][0]+mass[i][1]==10)
{
o = o+1;
}
else if(mass[i][0]>=4&&mass[i][1]>=4)
{
x = x+1;
}
else if (mass[i][0]==3||mass[i][1]==3)
{
y = y+1
}
else if (mass[i][0]==2||mass[i][1]==2)
{
ny = ny +1
}

}

document.getElementById("1").style.height = o*10+"px";
document.getElementById("2").style.height = x*10+"px";
document.getElementById("3").style.height = y*10+"px";
document.getElementById("4").style.height = ny*10+"px";
top
document.getElementById('pik').innerHTML = "Отличники "+o+"<br>"+ "Хорошо успевающие "+x+"<br>"+"Успевающие "+y+"<br>"+"Неуспевающие "+ny;

</script>
</body>
</html>