/// <binding BeforeBuild='clean' AfterBuild='copy' />
module.exports = function (grunt) {
    //Configuration setup
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        copy: {
            domain: {
                expand: true,
                cwd: 'DexCMS.Mileage/bin/Release/',
                src: ['DexCMS.Mileage.dll'],
                dest: 'dist/'
            },
            //mvc: {
            //    expand: true,
            //    cwd: 'DexCMS.Mileage.Mvc/bin/Release/',
            //    src: ['DexCMS.Mileage.Mvc.dll'],
            //    dest: 'dist/'
            //},
            webapi: {
                expand: true,
                cwd: 'DexCMS.Mileage.WebApi/bin/Release/',
                src: ['DexCMS.Mileage.WebApi.dll'],
                dest: 'dist/'
            }
        },
        clean: {
            build: ["dist"]
        }
    });

    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-clean');

    grunt.registerTask('default', ['clean', 'copy']);
};
