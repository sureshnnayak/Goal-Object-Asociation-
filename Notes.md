# ROS–Unity Demo Setup

clone : git clone git@github.com:Unity-Technologies/Unity-Robotics-Hub.git

1.
   a) If you don't already have a ROS2 environment set up, we recommend using Docker. Navigate to `tutorials/ros_unity_integration` in your copy of this repo and run the following commands:

   ```bash
   docker build -t foxy -f ros2_docker/Dockerfile .
   docker run -it --rm -p 10000:10000 foxy /bin/bash
   ```

   This should build a docker image and start it.

   2. In your Colcon workspace, run the following command, replacing `<your IP address>` with your ROS machine's IP or hostname.

 ```bash
 ros2 run ros_tcp_endpoint default_server_endpoint --ros-args -p ROS_IP:=<your IP address>
    ```

   - If you're running ROS in a Docker container, 0.0.0.0 is a valid incoming address, so you can write `ros2 run ros_tcp_endpoint default_server_endpoint --ros-args -p ROS_IP:=0.0.0.0`
   - On Linux you can find out your IP address with the command `hostname -I`
   - On MacOS you can find out your IP address with `ipconfig getifaddr en0`

   Once the server_endpoint has started, it will print something similar to `[INFO] [1603488341.950794]: Starting server on 192.168.50.149:10000`.
