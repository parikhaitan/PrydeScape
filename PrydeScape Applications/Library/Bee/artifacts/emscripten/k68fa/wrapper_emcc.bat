
@echo off
"C:\Program Files\Unity\Hub\Editor\2022.1.14f1\Editor\Data\PlaybackEngines\WebGLSupport\BuildTools\Emscripten\emscripten\emcc.bat" %* < nul
exit %ERRORLEVEL%
