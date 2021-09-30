## Unity-Vuforia-echo3D-demo-Museum
Example Unity project getting information about art using echo3D and Vuforia.

## Register
Don't have an API key? Make sure to register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).

## Setup
Follow the instructions on our [documentation page](https://docs.echo3D.co/unity/adding-ar-capabilities) to [set your API key](https://docs.echo3D.co/unity/adding-ar-capabilities#3-set-you-api-key).
* Clone this project and open the project in Unity, and open the *Museum* scene.
* Open the *echo3D* folder, click the echo3D prefab, and enter your API key.
* Upload the models from the [Models](/Models) folder to your echo3D project.
* Add in the metadata from metadata.csv in the [Models](/Models) folder.

## Vuforia
1. Register to Vufoeia
2. In [Vuforia's developers page](https://developer.vuforia.com/vui/develop/licenses), create a new license key by clicking *Get Development Key* and following the instructions. Click the new license and copy the license key.
3. Click *Target Manager* and add a new database. The new Database should be set to "Device".
4. Click the new database and add the targets from the [Targets](/Tragets) folder.
5. When you are done uploading the targets, click *Download Database* and choose *Unity Editor*. After its done downloading double click the downloaded file and import it to unity.
6. In Unity click the AR camera and then click the *Open Vuforia Engine Configuration* button in the inspector. Paste the license key you copied in step 2 to the *App license Key* input.

## Unity - Next Steps
1. In Unity , click the targets in the scene and in the *Image Target Behaviour* section, choose your database and the image for the target.

## Run
Simply press the _Play_ button in Unity. Now you should be able to see the painting information on the painting. Clicking the information will redirect you to the wikipedia page of the painting.

## Adjusting information model
You can easily change the information model location and size by following [adding information](https://docs.echo3D.co/unity/using-the-sdk#build-in-keywords) to its entry on echo3D. 

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join).

## Screenshots
![Vuforia - Create DB](/Screenshots/CreateDB.jpg)
![Vuforia - Download DB](/Screenshots/DownloadDB.jpg)
