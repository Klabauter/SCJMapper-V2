﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCJMapper_V2
{
  class JoystickList : List<JoystickCls>
  {
    private FormReassign FR = null;

    public Dictionary<int, int> JsReassingList { get; set; } // oldJs, newJs
    public List<int> NewJsList { get; set; }  // index is this[idx]

    /// <summary>
    /// Show the jsN Reassign Dialog
    /// </summary>
    public DialogResult ShowReassign( )
    {
      if ( FR == null ) {
        FR = new FormReassign( this );
        JsReassingList = new Dictionary<int, int>( );
        NewJsList = new List<int>( );
      }
      FR.ShowDialog( );
      if ( FR.Canceled == false ) {
        int jIdx = 0;
        // update the new js indication in the tabs
        foreach ( JoystickCls j in this ) j.JSAssignment = NewJsList[jIdx++];
        JoystickCls.ReassignJsColor( NewJsList );
      }
      return ( FR.Canceled ) ? DialogResult.Cancel : DialogResult.OK;
    }


    public void ResetJsNAssignment( )
    {
      foreach ( JoystickCls j in this ) j.JSAssignment = 0;
      if ( this.Count > 0 ) this[0].JSAssignment = 1;
      if ( this.Count > 1 ) this[1].JSAssignment = 2;
    }


    /// <summary>
    /// Returns the Joystick instance for the given jsN 
    /// </summary>
    /// <param name="n">The JsN</param>
    /// <returns>The instance or null if not found</returns>
    public JoystickCls Find_jsN( int n )
    {
      foreach ( JoystickCls j in this ) {
        if ( j.JSAssignment == n ) return j;
      }
      return null;
    }


    /// <summary>
    /// Returns the Joystick instance for the given device name
    /// </summary>
    /// <param name="n">The device name</param>
    /// <returns>The instance or null if not found</returns>
    public JoystickCls Find_jsDev( String devName )
    {
      foreach ( JoystickCls j in this ) {
        if ( j.DevName == devName ) return j;
      }
      return null;
    }


    /// <summary>
    /// Returns the Joystick instance for the given device instance GUID
    /// </summary>
    /// <param name="n">The instance GUID</param>
    /// <returns>The instance or null if not found</returns>
    public JoystickCls Find_jsInstance( String instGUID )
    {
      foreach ( JoystickCls j in this ) {
        if ( j.DevInstanceGUID == instGUID ) return j;
      }
      return null;
    }


  }
}
