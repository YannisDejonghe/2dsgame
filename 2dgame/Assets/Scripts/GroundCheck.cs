using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour { private Player player; void start() { player = gameObject.GetComponentInParent<Player>(); } void OnTriggerEnter2D(Collider2D col) { if (null == player) { start(); } player.grounded = true; } void OnTriggerExit2D(Collider2D col) { player.grounded = false; } }