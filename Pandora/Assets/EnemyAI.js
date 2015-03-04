#pragma strict

var Player : Transform;
var MoveSpeed = 5;
var MinDist = 0;
var MaxDist = 10;

function Start () {
	
}

function Update () {
	
	transform.LookAt(Player);
	
	if(Vector3.Distance(transform.position,Player.position) >= MinDist){
		
		transform.position += transform.forward*MoveSpeed*Time.deltaTime;
		
		if(Vector3.Distance(transform.position,Player.position) <= MaxDist){
			//Attack?
		}
	}
}