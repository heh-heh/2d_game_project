using UnityEngine;
using System.Collections.Generic;

// LookAtConstraint : Max Look ê³¼ ê°™ì€ ê¸°ëŠ¥ì„ í•©ë‹ˆë‹¤.
// ì œìž‘ : í™©êµ°

public class lookat_costom : MonoBehaviour
{
    public enum lookType
    {
		Camera,
		Nodes
    }
    public enum upType
    {
		Camera,
		Node,
		World
    }
    public enum axisType
    {
		X,
		Y,
		Z
    }
    public enum upCtrType
    {
		LootAt,
		AxisAlignment
    }
	
	public lookType lookAtType = lookType.Camera;
	public List<Transform> lookAtNodeList = new List<Transform>();
	public axisType lookAtAxis = axisType.Z;
	public bool lookAtFilp = false;
	
	public upType upAxisType = upType.World;
	public Transform upNode;
	public upCtrType upControl = upCtrType.AxisAlignment;
	
	public axisType sourceAxis = axisType.Y;
	public bool sourceFilp = false;
	public axisType alignedToUpnodeAxis = axisType.Y;
	
	
	
	//=========================================================================================
	// GetUpVector
	//=========================================================================================
	private Vector3 GetUpVector()
	{
		Vector3 upV = Vector3.zero;
		switch(upAxisType)
		{
			// Camera ì¶•ì¼ ë•Œ =============================================
			case upType.Camera:
			{
				if (Camera.main != null)
					upV = Camera.main.transform.position - transform.position;
				break;
			}
			//============================================================
			
			// Node ì¶•ì¼ ë•Œ ===============================================
			case upType.Node:
			{
				// Up Vectorë¥¼ LookAtìœ¼ë¡œ ì²˜ë¦¬ //
				if (upControl == upCtrType.LootAt)
				{
					upV = upNode.transform.position - transform.position;
					break;
				}
				
				// UpNodeê°€ ì—†ìœ¼ë©´ ë„˜ì–´ê°€ìž //
				if (upNode == null)
					break;
				
				// UpNodeê°€ ìžˆìœ¼ë©´ êµ¬í•˜ìž //
				switch(alignedToUpnodeAxis)
				{
					case axisType.X:
					{
						upV = upNode.right;
						break;
					}
					case axisType.Y:
					{
						upV = upNode.up;
						break;
					}
					case axisType.Z:
					{
						upV = upNode.forward;
						break;
					}
				}
				break;
			}
			//============================================================
			
			// World ì¶•ì¼ ë•Œ ==============================================
			case upType.World:
			{
				switch(alignedToUpnodeAxis)
				{
					case axisType.X:
					{
						upV = Vector3.right;
						break;
					}
					case axisType.Y:
					{
						upV = Vector3.up;
						break;
					}
					case axisType.Z:
					{
						upV = Vector3.forward;
						break;
					}
				}
				break;
			}
			//============================================================
		}
		
		return upV;
	}
	
	
	// LookAtQuat //
//	private void LookAtQuat1(params Vector3[] vecs)
//	{
//		if(vecs.Length!=3)
//			return;
//		
//		LookAtQuat(vecs[0], vecs[1], vecs[2]);
//	}
	
	
	//=========================================================================================
	// LookAtQuat
	//=========================================================================================
	private void LookAtQuat(Vector3 xvec, Vector3 yvec, Vector3 zvec)
	{
		float e = 1.0f + xvec.x + yvec.y + zvec.z;
		
		// 0.0fì´ë©´ Sqrt ì˜¤ë¥˜ ë‚¨//
		if(e == 0.0f)
			return;
			
		float qw = Mathf.Sqrt(e) / 2;
		float w	 = 4 * qw;
		float qx = (yvec.z - zvec.y) / w;
		float qy = (zvec.x - xvec.z) / w;
		float qz = (xvec.y - yvec.x) / w;
		Quaternion q = new Quaternion(qx, qy, qz, qw);
		transform.rotation = q;
		
//		Debug.Log(string.Format ("Quternion={0} ({4},{5},{6},{7}), xv={1},yv={2}, zv={3}, total={8}",
//			q,xvec,yvec,zvec,qx,qy,qz,qw, xvec.x + yvec.y + zvec.z));
	}
	
	
	//=========================================================================================
	// Update
	//=========================================================================================
	void Update()
	{
		// Upì¶• ì„¤ì • ==================================================
		Vector3 upV = GetUpVector();
		//============================================================
		
		// Look At Vector êµ¬í•˜ê¸° ======================================
		Vector3 lookAxis = Vector3.zero;
		Vector3 odrAxis	 = Vector3.zero;
		Vector3 upAxis	 = Vector3.zero;
		
		switch(lookAtType)
		{
			// LookAxis Camera ==============
			case lookType.Camera:
			{
				lookAxis = Vector3.Normalize(Camera.main.transform.position - transform.position);
				odrAxis	 = Vector3.Normalize(Vector3.Cross(upV, lookAxis));
				upAxis	 = Vector3.Cross(lookAxis, odrAxis);
				break;
			}
			//===============================
			
			// LookAxis Nodes ===============
			case lookType.Nodes:
			{
				// í‰ê· ê°’ êµ¬í•˜ê¸° //
				Vector3 centerPos = Vector3.zero;
				int nodeCount = 0;
				foreach(Transform lookNode in lookAtNodeList)
				{
					if (lookNode != null)
					{
						nodeCount += 1;
						centerPos += lookNode.position;
					}
				}
				centerPos = centerPos / nodeCount;
			
				lookAxis = Vector3.Normalize(centerPos - transform.position);
				odrAxis	 = Vector3.Normalize(Vector3.Cross(upV, lookAxis));
				upAxis	 = Vector3.Cross(lookAxis, odrAxis);
				break;
			}
			//===============================
		}
		//============================================================
		
		// LookAt Vector =============================================
		Vector3 xVector = Vector3.zero;
		Vector3 yVector = Vector3.zero;
		Vector3 zVector = Vector3.zero;
		
		// lookAtFilp //
		if (lookAtFilp)
		{
			lookAxis = -lookAxis;
			odrAxis	 = -odrAxis;
		}
		
		// lookAtAxis//
		switch(lookAtAxis)
		{
			case axisType.X:
			{
				// LookAxis //
				xVector = lookAxis;
			
				// UpAxis //
				if (sourceAxis == axisType.Y)
				{
					yVector = upAxis;
					zVector = -odrAxis;
				}
				else if (sourceAxis == axisType.Z)
				{
					yVector = odrAxis;
					zVector = upAxis;
				}
			
				// UpAxis Filp //
				if (sourceFilp)
				{
					yVector = -yVector;
					zVector = -zVector;
				}
				break;
			}
			case axisType.Y:
			{
				// LookAxis //
				yVector = lookAxis;
			
				// UpAxis //
				if (sourceAxis == axisType.X)
				{
					xVector = upAxis;
					zVector = odrAxis;
				}
				else if (sourceAxis == axisType.Z)
				{
					xVector = -odrAxis;
					zVector = upAxis;
				}
			
				// UpAxis Filp //
				if (sourceFilp)
				{
					xVector = -xVector;
					zVector = -zVector;
				}
				break;
			}
			case axisType.Z:
			{
				// LookAxis //
				zVector = lookAxis;
				
				// UpAxis //
				if (sourceAxis == axisType.X)
				{
					xVector = upAxis;
					yVector = -odrAxis;
				}
				else if (sourceAxis == axisType.Y)
				{
					xVector = odrAxis;
					yVector = upAxis;
				}
			
				// UpAxis Filp //
				if (sourceFilp)
				{
					xVector = -xVector;
					yVector = -yVector;
				}
				break;
			}
		}
		//============================================================
		
		// Look At ===================================================
		LookAtQuat(xVector, yVector, zVector);
		//============================================================
	}
}