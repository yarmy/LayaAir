#if defined(GL_FRAGMENT_PRECISION_HIGH)// 原来的写法会被我们自己的解析流程处理，而我们的解析是不认内置宏的，导致被删掉，所以改成 if defined 了
precision highp float; 
#else 
    precision mediump float; 
#endif 

uniform float u_OutlineLightness; 
uniform vec4 u_OutlineColor;

void main() 
{ 
    vec3 finalColor = u_OutlineColor.rgb * u_OutlineLightness; 
    gl_FragColor = vec4(finalColor,0.0); 
}