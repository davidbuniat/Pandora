#pragma strict

var Player : Transform;
var MoveSpeed = 5;
var MinDist = 1;
var MaxDist = 10;

function Start () {

	Player = GameObject.FindGameObjectWithTag("Player").transform;
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