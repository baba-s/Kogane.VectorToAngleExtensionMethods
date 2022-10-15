using UnityEngine;

namespace Kogane
{
    public static class VectorToAngleExtensionMethods
    {
        public static float ToRadian( this Vector2 self )
        {
            return Mathf.Atan2( self.y, self.x );
        }

        public static float ToDegree( this Vector2 self )
        {
            return Mathf.Atan2( self.y, self.x ) * Mathf.Rad2Deg;
        }

        public static Vector2 RadianToVector2( this float self )
        {
            return new( Mathf.Cos( self ), Mathf.Sin( self ) );
        }

        public static Vector2 DegreeToVector2( this float self )
        {
            return new( Mathf.Cos( self * Mathf.Deg2Rad ), Mathf.Sin( self * Mathf.Deg2Rad ) );
        }
    }
}