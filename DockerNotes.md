## Docker Notes

- To search for an image, use **docker search _imagename_**
```bash
$ docker search redis
NAME                              DESCRIPTION                                     STARS               OFFICIAL            AUTOMATEDredis                             Redis is an open source key-value store that…   6653                [OK]
bitnami/redis                     Bitnami Redis Docker Image                      106                                     [OK]sameersbn/redis                                                                   76                                      [OK]
grokzen/redis-cluster             Redis cluster 3.0, 3.2, 4.0 & 5.0               44hypriot/rpi-redis                 Raspberry Pi compatible redis image             33
kubeguide/redis-master            redis-master with "Hello World!"                28kubeguide/guestbook-redis-slave   Guestbook redis slave                           22
rediscommander/redis-commander    Alpine image for redis-commander - Redis man…   21                                      [OK]redislabs/redis                   Clustered in-memory database engine compatib…   19
redislabs/redisearch              Redis With the RedisSearch module pre-loaded…   15arm32v7/redis                     Redis is an open source key-value store that…   14
oliver006/redis_exporter           Prometheus Exporter for Redis Metrics. Supp…   10webhippie/redis                   Docker images for Redis                         10                                      [OK]
s7anley/redis-sentinel-docker     Redis Sentinel                                  7                                       [OK]insready/redis-stat               Docker image for the real-time Redis monitor…   7                                       [OK]
arm64v8/redis                     Redis is an open source key-value store that…   5rtoma/logspout-redis-logstash     Logspout including Redis adapter for sending…   5
centos/redis-32-centos7           Redis in-memory data structure store, used a…   4circleci/redis                    CircleCI images for Redis                       2                                       [OK]
wodby/redis                       Redis container image with orchestration        2                                       [OK]frodenas/redis                    A Docker Image for Redis                        2                                       [OK]
tiredofit/redis                   Redis Server w/ Zabbix monitoring and S6 Ove…   1                                       [OK]cflondonservices/redis            Docker image for running redis                  0
iadvize/redis                                                                     0xetamus/redis-resource            forked redis-resource                           0                                       [OK]
```
- To run a particular image in background mode, use **docker run -d _imagename_**
```bash
$ docker run -d redis
6e8a2faebf69e50c0cad6b929534509c37cbdfbff23464a35fc391e0ebb7df4e
```

- **docker ps** to list all running containers, the image used to start the container and uptime

```bash
$ docker ps
CONTAINER ID        IMAGE               COMMAND                  CREATED             STATUS              PORTS               NAMES
6e8a2faebf69        redis               "docker-entrypoint.s…"   15 seconds ago      Up 13 seconds       6379/tcp            eloquent_ride
```

- **docker inspect _friendly-name|container-id_** provides more details about a running container, such as IP address
- **docker logs _friendly-name|container-id_** displays messages the container has written to standard error or standard out

```bash
$ docker inspect 6e8
[
    {
        "Id": "6e8a2faebf69e50c0cad6b929534509c37cbdfbff23464a35fc391e0ebb7df4e",
        "Created": "2019-03-17T00:22:21.19331384Z",
        "Path": "docker-entrypoint.sh",
        "Args": [
            "redis-server"
        ],
        "State": {
            "Status": "running",
            "Running": true,
            "Paused": false,
            "Restarting": false,
            "OOMKilled": false,
            "Dead": false,
            "Pid": 932,
            "ExitCode": 0,
            "Error": "",
            "StartedAt": "2019-03-17T00:22:22.345237321Z",
            "FinishedAt": "0001-01-01T00:00:00Z"
        },
        "Image": "sha256:4760dc956b2ddc9ac1c508936e39b63a22c6f0640ef58c1b10ff73f04e253ffe",
        "ResolvConfPath": "/var/lib/docker/containers/6e8a2faebf69e50c0cad6b929534509c37cbdfbff23464a35fc391e0ebb7df4e/resolv.conf",
        "HostnamePath": "/var/lib/docker/containers/6e8a2faebf69e50c0cad6b929534509c37cbdfbff23464a35fc391e0ebb7df4e/hostname",
        "HostsPath": "/var/lib/docker/containers/6e8a2faebf69e50c0cad6b929534509c37cbdfbff23464a35fc391e0ebb7df4e/hosts",
        "LogPath": "/var/lib/docker/containers/6e8a2faebf69e50c0cad6b929534509c37cbdfbff23464a35fc391e0ebb7df4e/6e8a2faebf69e50c0cad6b929534509c37cbdfbff23464a35fc391e0ebb7df4e-json.log",
        "Name": "/eloquent_ride",
        "RestartCount": 0,
        "Driver": "overlay",
        "Platform": "linux",
        "MountLabel": "",
        "ProcessLabel": "",
        "AppArmorProfile": "",
        "ExecIDs": null,
        "HostConfig": {
            "Binds": null,
            "ContainerIDFile": "",
            "LogConfig": {
                "Type": "json-file",
                "Config": {}
            },
            "NetworkMode": "default",
            "PortBindings": {},
            "RestartPolicy": {
                "Name": "no",
                "MaximumRetryCount": 0
            },
            "AutoRemove": false,
            "VolumeDriver": "",
            "VolumesFrom": null,
            "CapAdd": null,
            "CapDrop": null,
            "Dns": [],
            "DnsOptions": [],
            "DnsSearch": [],
            "ExtraHosts": null,
            "GroupAdd": null,
            "IpcMode": "shareable",
            "Cgroup": "",
            "Links": null,
            "OomScoreAdj": 0,
            "PidMode": "",
            "Privileged": false,
            "PublishAllPorts": false,
            "ReadonlyRootfs": false,
            "SecurityOpt": null,
            "UTSMode": "",
            "UsernsMode": "",
            "ShmSize": 67108864,
            "Runtime": "runc",
            "ConsoleSize": [
                0,
                0
            ],
            "Isolation": "",
            "CpuShares": 0,
            "Memory": 0,
            "NanoCpus": 0,
            "CgroupParent": "",
            "BlkioWeight": 0,
            "BlkioWeightDevice": [],
            "BlkioDeviceReadBps": null,
            "BlkioDeviceWriteBps": null,
            "BlkioDeviceReadIOps": null,
            "BlkioDeviceWriteIOps": null,
            "CpuPeriod": 0,
            "CpuQuota": 0,
            "CpuRealtimePeriod": 0,
            "CpuRealtimeRuntime": 0,
            "CpusetCpus": "",
            "CpusetMems": "",
            "Devices": [],
            "DeviceCgroupRules": null,
            "DiskQuota": 0,
            "KernelMemory": 0,
            "MemoryReservation": 0,
            "MemorySwap": 0,
            "MemorySwappiness": null,
            "OomKillDisable": false,
            "PidsLimit": 0,
            "Ulimits": null,
            "CpuCount": 0,
            "CpuPercent": 0,
            "IOMaximumIOps": 0,
            "IOMaximumBandwidth": 0
        },
        "GraphDriver": {
            "Data": {
                "LowerDir": "/var/lib/docker/overlay/d5d206b9df9a3642afb5a4767df56cf1770db74b9de93724098e86acf3ff97f3/root",
                "MergedDir": "/var/lib/docker/overlay/dcc2ef4f83bca27d174a83ad32797d98b33792e6fc3fd7710f304f4306e361e2/merged",
                "UpperDir": "/var/lib/docker/overlay/dcc2ef4f83bca27d174a83ad32797d98b33792e6fc3fd7710f304f4306e361e2/upper",
                "WorkDir": "/var/lib/docker/overlay/dcc2ef4f83bca27d174a83ad32797d98b33792e6fc3fd7710f304f4306e361e2/work"
            },
            "Name": "overlay"
        },
        "Mounts": [
            {
                "Type": "volume",
                "Name": "53856bcc2c992372cda13941b8c58173423b48df9c0d86fb1c032c82160b71e9",
                "Source": "/var/lib/docker/volumes/53856bcc2c992372cda13941b8c58173423b48df9c0d86fb1c032c82160b71e9/_data",
                "Destination": "/data",
                "Driver": "local",
                "Mode": "",
                "RW": true,
                "Propagation": ""
            }
        ],
        "Config": {
            "Hostname": "6e8a2faebf69",
            "Domainname": "",
            "User": "",
            "AttachStdin": false,
            "AttachStdout": false,
            "AttachStderr": false,
            "ExposedPorts": {
                "6379/tcp": {}
            },
            "Tty": false,
            "OpenStdin": false,
            "StdinOnce": false,
            "Env": [
                "PATH=/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin",
                "GOSU_VERSION=1.10",
                "REDIS_VERSION=4.0.8",
                "REDIS_DOWNLOAD_URL=http://download.redis.io/releases/redis-4.0.8.tar.gz",
                "REDIS_DOWNLOAD_SHA=ff0c38b8c156319249fec61e5018cf5b5fe63a65b61690bec798f4c998c232ad"
            ],
            "Cmd": [
                "redis-server"
            ],
            "ArgsEscaped": true,
            "Image": "redis",
            "Volumes": {
                "/data": {}
            },
            "WorkingDir": "/data",
            "Entrypoint": [
                "docker-entrypoint.sh"
            ],
            "OnBuild": null,
            "Labels": {}
        },
        "NetworkSettings": {
            "Bridge": "",
            "SandboxID": "64ae8a7650ddbbd7ca1baff4fda28fd5389692f4ccc45cfd9fc9109f92456b4c",
            "HairpinMode": false,
            "LinkLocalIPv6Address": "",
            "LinkLocalIPv6PrefixLen": 0,
            "Ports": {
                "6379/tcp": null
            },
            "SandboxKey": "/var/run/docker/netns/64ae8a7650dd",
            "SecondaryIPAddresses": null,
            "SecondaryIPv6Addresses": null,
            "EndpointID": "1b7015c16651ac865b4e1d4c9a8bace19148d027c7bf6f3e93ce0f632fbd3638",
            "Gateway": "172.18.0.1",
            "GlobalIPv6Address": "",
            "GlobalIPv6PrefixLen": 0,
            "IPAddress": "172.18.0.2",
            "IPPrefixLen": 24,
            "IPv6Gateway": "",
            "MacAddress": "02:42:ac:12:00:02",
            "Networks": {
                "bridge": {
                    "IPAMConfig": null,
                    "Links": null,
                    "Aliases": null,
                    "NetworkID": "35d62f44bddb8db1b1f62dcdc71715e843262bf925f43f7ba755eba5a5d94c2b",
                    "EndpointID": "1b7015c16651ac865b4e1d4c9a8bace19148d027c7bf6f3e93ce0f632fbd3638",
                    "Gateway": "172.18.0.1",
                    "IPAddress": "172.18.0.2",
                    "IPPrefixLen": 24,
                    "IPv6Gateway": "",
                    "GlobalIPv6Address": "",
                    "GlobalIPv6PrefixLen": 0,
                    "MacAddress": "02:42:ac:12:00:02",
                    "DriverOpts": null
                }
            }
        }
    }
]
```

- To run Redis in the background, with a name of redisHostPort on port 6379 use the following command:
```bash
$ docker run -d --name redisHostPort -p 6379:6379 redis:latest
b59dc533bea6ea02c6472613bebb2ee523b185d7387581411f9ab5400045f7cd
```
*Tip: By default, the port on the host is mapped to 0.0.0.0, which means all IP addresses. You can specify a particular IP address when you define the port mapping, for example, -p 127.0.0.1:6379:6379*

- To run Redis in the background, with a name of redisDynamic on a random port use:
```
$ docker run -d --name redisDynamic -p 6379 redis:latest
eded5dd5581d28eaa2d218b4577acc5b17a344ebd17728d32583b25799c7e641
```
- To discover which port has been assigned with the above command:
```
$ docker port redisDynamic 6379
0.0.0.0:32768
```
- To display list of all containers with port mapping information:
```
$ docker ps
CONTAINER ID        IMAGE               COMMAND                  CREATED              STATUS              PORTS                     NAMES
eded5dd5581d        redis:latest        "docker-entrypoint.s…"   25 seconds ago       Up 23 seconds       0.0.0.0:32768->6379/tcp   redisDynamic
b59dc533bea6        redis:latest        "docker-entrypoint.s…"   About a minute ago   Up About a minute   0.0.0.0:6379->6379/tcp    redisHostPort
6e8a2faebf69        redis               "docker-entrypoint.s…"   3 minutes ago        Up 3 minutes        6379/tcp                  eloquent_ride
```
- Containers are designed to be stateless. Binding directories (also known as volumes) is done using the option -v _host-dir:container-dir_. When a directory is mounted, the files which exist in that directory on the host can be accessed by the container and any data changed/written to the directory inside the container will be stored on the host. This allows you to upgrade or change containers without losing your data.

- Any data which needs to be saved on the Docker Host, and not inside containers, should be stored in /opt/docker/data/redis

- Docker allows you to use $PWD as a placeholder for the current directory
```
$ docker run -d --name redisMapped -v /opt/docker/data/redis:/data redis
8cf422b79db7978f4c6df4bb5913a67c5f5f548b7586e0ab1328c8407312c7b2
```

- The command **docker run ubuntu ps** launches an Ubuntu container and executes the command ps to view all the processes running in a container.
```
$ docker run ubuntu ps
  PID TTY          TIME CMD
    1 ?        00:00:00 ps
```

- The command **docker run -it ubuntu bash** allows to get access to a bash shell inside of a container.
```
$ docker run -it ubuntu bash
root@c075ad40eeab:/#
```

### Deploying Static HTML Website as Container

- Docker Images start from a base image. The base image should include the platform dependencies required by your application, for example, having the JVM or CLR installed.
- This base image is defined as an instruction in the Dockerfile. Docker Images are built based on the contents of a Dockerfile. The Dockerfile is a list of instructions describing how to deploy your application.
- In this example, our base image is the Alpine version of Nginx. This provides the configured web server on the Linux Alpine distribution.


#### Create a Dockerfile (without extension) for building the image

```
FROM nginx:alpine
COPY . /usr/share/nginx/html
```
- The first line defines our base image. 
- The second line copies the content of the current directory into a particular location inside the container.


#### Creating Dockerfile
- The Dockerfile is used by the Docker CLI build command. 
- The build command executes each instruction within the Dockerfile. 
- The result is a built Docker Image that can be launched and run your configured app.
- The build command takes in some different parameters. 
- The format is docker build -t _build-directory_ . 
- The -t parameter allows you to specify a friendly name for the image and a tag, commonly used as a version number. This allows you to track built images and be confident about which version is being started.
```
$ docker build -t webserver-image:v1 .
Sending build context to Docker daemon  3.072kB
Step 1/2 : FROM nginx:alpine
 ---> 32a037976344
Step 2/2 : COPY . /usr/share/nginx/html
 ---> c587e13a199c
Successfully built c587e13a199c
Successfully tagged webserver-image:v1
```
- **docker images** displays list of all images
```
$ docker images
REPOSITORY          TAG                 IMAGE ID            CREATED             SIZE
webserver-image     v1                  c587e13a199c        3 seconds ago       16.1MB
nginx               alpine              32a037976344        9 days ago          16.1MB
redis               latest              4760dc956b2d        12 months ago       107MB
ubuntu              latest              f975c5035748        12 months ago       112MB
alpine              latest              3fd9065eaf02        14 months ago       4.14MB
```
- The built Image can be launched in a consistent way to other Docker Images. When a container launches, it's sandboxed from other processes and networks on the host. When starting a container you need to give it permission and access to what it requires.
- For example, to open and bind to a network port on the host you need to provide the parameter -p _host-port:container-port_.
- Launch our newly built image providing the friendly name and tag. As it's a web server, bind port 80 to our host using the -p parameter.
```
$ docker run -d -p 80:80 webserver-image:v1
bf2b81c8075f9f8d693193f6f7c39a8c2b9c116eb08aa2104f30ffcc128582b2
```
- Once started, you'll be able to access the results of port 80 via curl docker:
```
$ curl docker
<h1>Hello World</h1>
```
- You now have a static HTML website being served by Nginx.

### Docker - Building Container Images
- Docker images are built based on a Dockerfile. 
- A Dockerfile defines all the steps required to create a Docker image with your application configured and ready to be run as a container. 
- The image itself contains everything, from operating system to dependencies and configuration required to run your application.
- Having everything within the image allows you to migrate images between different environments and be confident that if it works in one environment, then it will work in another.
- The Dockerfile allows for images to be composable, enabling users to extend existing images instead of building from scratch. 
- By building on an existing image, you only need to define the steps to setup your application. 
- The base images can be basic operating system installations or configured systems which simply need some additional customisations.

- All Docker images start from a base image. 
- A base image is the same images from the Docker Registry which are used to start containers. 
- Along with the image name, we can also include the image tag to indicate which particular version we want, by default, this is latest.
- These base images are used as the foundation for your additional changes to run your application. 
- For example, in this scenario, we require NGINX to be configured and running on the system before we can deploy our static HTML files. As such we want to use NGINX as our base image.
```
FROM nginx:1.11-alpine
```

- Dockerfile's are simple text files with a command on each line. To define a base image we use the instruction FROM _image-name_:_tag_
- With the base image defined, we need to run various commands to configure our image. There are many commands to help with this, the main commands two are COPY and RUN.
- RUN command allows you to execute any command as you would at a command prompt, for example installing different application packages or running a build command. The results of the RUN are persisted to the image so it's important not to leave any unnecessary or temporary files on the disk as these will be included in the image.
- COPY _src_ _dest_ allows you to copy files from the directory containing the Dockerfile to the container's image. This is extremely useful for source code and assets that you want to be deployed inside your container.
- If you're copying a file into a directory then you need to specify the filename as part of the destination
```
FROM nginx:1.11-alpine
copy index.html /usr/share/nginx/html/index.html
```
- With our files copied into our image and any dependencies downloaded, you need to define which port application needs to be accessible on.
- Using the EXPOSE <port> command you tell Docker which ports should be open and can be bound too. You can define multiple ports on the single command, for example, EXPOSE 80 433 or EXPOSE 7000-8000
```
FROM nginx:1.11-alpine
copy index.html /usr/share/nginx/html/index.html
EXPOSE 80
```
- With the Docker image configured and having defined which ports we want accessible, we now need to define the command that launches the application.
- The CMD line in a Dockerfile defines the default command to run when a container is launched. If the command requires arguments then it's recommended to use an array, for example ["cmd", "-a", "arga value", "-b", "argb-value"], which will be combined together and the command cmd -a "arga value" -b argb-value would be run.

- The command to run NGINX is nginx -g daemon off;. Set this as the default command in the Dockerfile.

*Tip:
An alternative approach to CMD is ENTRYPOINT. While a CMD can be overridden when the container starts, a ENTRYPOINT defines a command which can have arguments passed to it when the container launches.
*
- In this example, NGINX would be the entrypoint with -g daemon off; the default command.
```
FROM nginx:1.11-alpine
copy index.html /usr/share/nginx/html/index.html
EXPOSE 80
CMD ["nginx","-g","daemon off;"]
```
- After writing your Dockerfile you need to use docker build to turn it into an image. 
- The build command takes in a directory containing the Dockerfile, executes the steps and stores the image in your local Docker Engine. If one fails because of an error then the build stops.
- You can give the image a friendly name by using the -t <name> option.

```
$ docker build .
Sending build context to Docker daemon  3.072kB
Step 1/4 : FROM nginx:1.11-alpine
 ---> bedece1f06cc
Step 2/4 : copy index.html /usr/share/nginx/html/index.html
 ---> 09e1bc98bbe8
Step 3/4 : EXPOSE 80
 ---> Running in e5c524ef3d4e
Removing intermediate container e5c524ef3d4e
 ---> 339565fda0df
Step 4/4 : CMD ["nginx","-g","daemon off;"]
 ---> Running in a4cbc7f18102
Removing intermediate container a4cbc7f18102
 ---> 3f4febbbb3ef
Successfully built 3f4febbbb3ef
$
```
*Tip:
You can use docker images to see a list of the images on your local machine.*
```
$ docker images
REPOSITORY          TAG                 IMAGE ID            CREATED             SIZE
<none>              <none>              3f4febbbb3ef        55 seconds ago      54.3MB
redis               latest              4760dc956b2d        12 months ago       107MB
ubuntu              latest              f975c5035748        12 months ago       112MB
alpine              latest              3fd9065eaf02        14 months ago       4.14MB
nginx               1.11-alpine         bedece1f06cc        23 months ago       54.3MB
$
```
- With the image successfully created, you can now launch the container in the same way we described in the first scenario.
- Launch an instance of your newly built image using either the ID result from the build command or the friendly name you assigned it.
- NGINX is designed to run as a background service so you should include the option -d. 
- To make the web server accessible, bind it to port 80 using p 80:80

```
docker run -d -p 80:80 \<image-id|friendly-tag-name\>
```
You can access the launched web server via the hostname docker. After launching the container, the command curl -i http://docker will return our index file via NGINX and the image we built.

Tip: You can check the container is running using docker ps
```
$ docker images
REPOSITORY          TAG                 IMAGE ID            CREATED             SIZE
<none>              <none>              3f4febbbb3ef        4 minutes ago       54.3MB
redis               latest              4760dc956b2d        12 months ago       107MB
ubuntu              latest              f975c5035748        12 months ago       112MB
alpine              latest              3fd9065eaf02        14 months ago       4.14MB
nginx               1.11-alpine         bedece1f06cc        23 months ago       54.3MB
$ docker run -d -p 80:80 3f4
fd8e4308e794bee8956ea46a895558eab71e209036e7bfa6b12286e5f9a9969b
$ curl -i http://docker
HTTP/1.1 200 OK
Server: nginx/1.11.13
Date: Sun, 17 Mar 2019 03:20:57 GMT                                                                   RTS               NAMES
Content-Type: text/html
Content-Length: 21
Last-Modified: Sun, 17 Mar 2019 02:51:58 GMT
Connection: keep-alive
ETag: "5c8db64e-15"
Accept-Ranges: bytes

<h1>Hello World</h1>
$ docker ps
CONTAINER ID        IMAGE               COMMAND                  CREATED             STATUS   PORTS                         NAMES
fd8e4308e794        3f4                 "nginx -g 'daemon of…"   36 seconds ago      Up 34 seconds   0.0.0.0:80->80/tcp, 443/tcp   lucid_spence
$
```

### Dockerizing Node.js applications

Step 1 - Base Image

- All images started with a base image, ideally as close to your desired configuration as possible. 
- Node.js has pre-built images available with tags for each released version.
- The image for Node 10.0 is node:10-alpine. 
- This is an Alpine-based build which is smaller and more streamlined than the official image.
- Alongside the base image, we also need to create the base directories of where the application runs from. 
- Using the RUN <command> we can execute commands as if they're running from a command shell, by using mkdir we can create the directories where the application will execute from. 
- An ideal directory would be /src/app as the environment user has read/write access to this directory.
- We can define a working directory using WORKDIR <directory> to ensure that all future commands are executed from the directory relative to our application.

- To define Base Environment
Set the FROM <image>:<tag>, RUN <command> and WORKDIR <directory> on separate lines to configure the base environment for deploying your application.
    
```
FROM node:10-apline
RUN mkdir -p /src/app
WORKDIR /src/app
```

Step 2 - NPM Install
- Add the following two lines in order for Dockerfile to run npm install.

```
COPY package.json /src/app/package.json
RUN npm install
```

Step 3 - Configuring Application

- We can copy the entire directory where our Dockerfile is using COPY . <dest dir>.
- Once the source code has been copied, the ports the application requires to be accessed is defined using EXPOSE <port>.
- Finally, the application needs to be started using the npm start command. 
- This looks in the package.json file to know how to launch the application saving duplication of commands.

```
COPY . /src/app
EXPOSE 3000
CMD [ "npm", "start" ]
```

Step 4 - Building & Launching Container
- To launch your application inside the container you first need to build an image.
- The command to build the image is 
```
docker build -t my-nodejs-app .
```
The command to launch the built image is 
```
docker run -d --name my-running-app -p 3000:3000 my-nodejs-app
```

Step 5 - Testing Container

- You can test the container is accessible using curl. 
- If the application responds then you know that everything has correctly started.
```
curl http://docker:3000
```
OUTPUT:
```
$ docker build -t my-nodejs-app .
Sending build context to Docker daemon  17.92kB
Step 1/8 : FROM node:10-alpine
10-alpine: Pulling from library/node
8e402f1a9c57: Pull complete
ca2222b63ac5: Pull complete
5d2ca3ce7154: Pull complete
Digest: sha256:b85a3b0ef76f5543b3f467e8a25694e72594d2c2bfcf140fa584d4f40ace4130
Status: Downloaded newer image for node:10-alpine
 ---> 94f3c8956482
Step 2/8 : RUN mkdir -p /src/app
 ---> Running in 641efc8fe0de
Removing intermediate container 641efc8fe0de
 ---> 5847eb57fd2c
Step 3/8 : WORKDIR /src/app
Removing intermediate container a00d9ba89828
 ---> a2761fdc41ff
Step 4/8 : COPY package.json /src/app/package.json
 ---> 031cc4b3637e
Step 5/8 : RUN npm install
 ---> Running in b6756754e3cd
npm WARN deprecated jade@1.6.0: Jade has been renamed to pug, please install the latest version of pug instead of jade
npm WARN deprecated transformers@2.1.0: Deprecated, use jstransformer
npm WARN deprecated constantinople@2.0.1: Please update to at least constantinople 3.1.1
npm notice created a lockfile as package-lock.json. You should commit this file.
added 78 packages from 74 contributors and audited 143 packages in 3.259s
found 28 vulnerabilities (11 low, 12 moderate, 5 high)
  run `npm audit fix` to fix them, or `npm audit` for details
Removing intermediate container b6756754e3cd
 ---> e293e4ff5a7f
Step 6/8 : COPY . /src/app
 ---> 43ee6cffba36
Step 7/8 : EXPOSE 3000
 ---> Running in 0f0f85fe5a62
Removing intermediate container 0f0f85fe5a62
 ---> 4e6e9a4f3254
Step 8/8 : CMD [ "npm", "start" ]
 ---> Running in 3a0ba59e6cd1
Removing intermediate container 3a0ba59e6cd1
 ---> f02e17b53148
Successfully built f02e17b53148
Successfully tagged my-nodejs-app:latest
$ docker run -d --name my-running-app -p 3000:3000 my-nodejs-app
3619f694ca34ad8e0658f74756dea9b41271eb418d87fbac620eb68ce5b321d3
$ curl http://docker:3000
<!DOCTYPE html><html><head><title>Express</title><link rel="stylesheet" href="/stylesheets/style.css"></head><body><h1>Express</h1><p>Welcome to Express</p></body></html>$
```

