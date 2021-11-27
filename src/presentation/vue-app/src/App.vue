<template>
  <v-app>
    <NaviationBar />
    <v-main>
      <router-view />
    </v-main>
  </v-app>
</template>

<script>
import NaviationBar from "@/components/NavigationBar"
export default {
  name: "App",
  components: {
    NaviationBar
  },
  data: () => ({
    //
  }),
};
</script>
