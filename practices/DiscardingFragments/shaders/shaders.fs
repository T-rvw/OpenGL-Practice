#version 400 core
out vec4 FragColor;

in vec2 TexCoords;

// texture sampler
uniform sampler2D texture1;

void main()
{
    vec4 texColor = texture(texture1, TexCoords);
    if(texColor.a < 0.1)
        discard;
    FragColor = texColor;
}