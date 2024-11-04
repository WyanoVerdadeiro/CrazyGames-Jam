using GameLovers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.MonoComponent
{
	public class PieceSpawnerMonoComponent : MonoBehaviour
	{
		private IObjectPool<GameObject> _objectPool;

		private void Awake()
		{
		}
	}
}
