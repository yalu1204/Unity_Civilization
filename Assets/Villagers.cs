using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villagers : MonoBehaviour
{
  protected float health;
  protected int age, skill_level;
  protected bool is_working;
  protected List<Item> inventory;
  protected Job job;

  protected virtual void move()
  {
    // This method will be overridden by each specific job class to implement the specific task code.
  }
}
public struct Item
{
  int number_of_item;
  string name_if_item;
}
public enum Job
{
  Agriculturist,
  Blacksmith,
  Carpenter,
  Healer,
  Merchant,
  Scout,
  Treasurer,
  Engineer,
  Herder,
  Mason,
  Recycler,
  Researcher,
  Sailor,
  Woodcutter,
  Hunter,
  Miner,
  Collector,
  Pharmacist,
  Religious_Leader,
  Fisherman,
  Fighter,
  Builder
}